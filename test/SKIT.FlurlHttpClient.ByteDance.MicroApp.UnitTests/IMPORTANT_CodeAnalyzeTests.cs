using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    using SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi;
    using SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi;
    using SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi;
    using SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast;

    public class CodeAnalyzeTests
    {
        // NOTICE:
        //   如果 Visual Studio 遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
        //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

        [Fact(DisplayName = "代码质量分析")]
        public void CodeAnalyze()
        {
            Assert.Multiple(
                CodeAnalyze_BaseSDK,
                CodeAnalyze_ExtendedSDK_OpenApi,
                CodeAnalyze_ExtendedSDK_ProductApi,
                CodeAnalyze_ExtendedSDK_RoleApi,
                CodeAnalyze_ExtendedSDK_Webcast
            );
        }

        private void CodeAnalyze_BaseSDK()
        {
            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.Events",
                    IgnoreExecutingExtensionTypes = static type => type.Namespace!.Contains(".ExtendedSDK."),
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true,
                    ThrowOnNotFoundWebhookEventTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.Models",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.Events",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.ByteDance.MicroApp/"),
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests/"),
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/_/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/_/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/_/",
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundWebhookEventClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true,
                    ThrowOnNotFoundWebhookEventSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options)
                    .AddRule((_, _, cur) =>
                    {
                        if (cur.ContentKind != SourceFileContentKinds.ExecutingExtensionClassCode ||
                            cur.FileKind != SourceFileKinds.CSharp)
                            return;

                        using FileStream stream = cur.FileInfo.Open(FileMode.Open, FileAccess.Read);
                        using TextReader streamReader = new StreamReader(stream);
                        SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(streamReader.ReadToEnd()).WithFilePath(cur.FileInfo.FullName);
                        CompilationUnitSyntax syntaxRootNode = syntaxTree.GetCompilationUnitRoot();
                        MethodDeclarationSyntax[] syntaxMethodDeclarationNodes = syntaxRootNode.Members
                            .Where(s => SourceFileCodeSyntaxKinds.BaseNamespaceDeclaration.Contains(s.Kind()))
                            .OfType<BaseNamespaceDeclarationSyntax>()
                            .SelectMany(s => s.Members
                                .Where(s => s.IsKind(SyntaxKind.ClassDeclaration))
                                .OfType<ClassDeclarationSyntax>()
                                .Where(s => s.Identifier.ToFullString().Contains("ExecuteLegacy")) // 仅扫描旧版 API
                            )
                            .SelectMany(s => s.Members
                                .Where(s => s.IsKind(SyntaxKind.MethodDeclaration))
                                .OfType<MethodDeclarationSyntax>()
                            )
                            .Where(s =>
                            {
                                string methodName = s.Identifier.ToFullString().Trim();
                                return methodName.StartsWith("Execute") &&
                                       methodName.EndsWith("Async");
                            })
                            .ToArray();
                        foreach (MethodDeclarationSyntax syntaxMethodDeclarationNode in syntaxMethodDeclarationNodes)
                        {
                            string methodName = syntaxMethodDeclarationNode.Identifier.ToFullString().Trim();

                            ExecutingMethodUrlPathSegmentsSyntaxWalker syntaxWalker = new ExecutingMethodUrlPathSegmentsSyntaxWalker();
                            syntaxWalker.Reset().Visit(syntaxMethodDeclarationNode);

                            string[] urlPathSegments1 = syntaxWalker.Result1 ?? Array.Empty<string>();
                            string[] urlPathSegments2 = syntaxWalker.Result2 ?? Array.Empty<string>();
                            for (int i = 0, len = Math.Max(urlPathSegments1.Length, urlPathSegments1.Length); i < len; i++)
                            {
                                string? s1 = urlPathSegments1.Length > i ? urlPathSegments1[i] : null;
                                string? s2 = urlPathSegments2.Length > i ? urlPathSegments2[i] : null;
                                if (!string.Equals(s1, s2))
                                    throw new AnalysisException($"文件 \"{cur.FileInfo.FullName}\"下的函数 \"{methodName}\" 应是一个 API 接口方法、且适配旧版入口点，但其 URL 路径的代码实现存在冲突。（Expected: \"{"/" + string.Join("/", urlPathSegments1)}\", Actual: \"{"/" + string.Join("/", urlPathSegments2)}\"）");
                            }
                        }
                    })
                    .AssertNoIssues();
            }));
        }

        private void CodeAnalyze_ExtendedSDK_OpenApi()
        {
            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Events",
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true,
                    ThrowOnNotFoundWebhookEventTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppOpenApiClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Events",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.ByteDance.MicroApp/"),
                    ProjectSourceRequestModelClassCodeSubDirectory = "ExtendedSDK/OpenApi/Models/",
                    ProjectSourceResponseModelClassCodeSubDirectory = "ExtendedSDK/OpenApi/Models/",
                    ProjectSourceExecutingExtensionClassCodeSubDirectory = "ExtendedSDK/OpenApi/Extensions/",
                    ProjectSourceWebhookEventClassCodeSubDirectory = "ExtendedSDK/OpenApi/Events/",
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests/"),
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/OpenApi/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/OpenApi/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/OpenApi/",
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundWebhookEventClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true,
                    ThrowOnNotFoundWebhookEventSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options)
                    .AddRule((_, _, cur) =>
                    {
                        if (cur.ContentKind != SourceFileContentKinds.ExecutingExtensionClassCode ||
                            cur.FileKind != SourceFileKinds.CSharp)
                            return;

                        using FileStream stream = cur.FileInfo.Open(FileMode.Open, FileAccess.Read);
                        using TextReader streamReader = new StreamReader(stream);
                        SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(streamReader.ReadToEnd()).WithFilePath(cur.FileInfo.FullName);
                        CompilationUnitSyntax syntaxRootNode = syntaxTree.GetCompilationUnitRoot();
                        MethodDeclarationSyntax[] syntaxMethodDeclarationNodes = syntaxRootNode.Members
                            .Where(s => SourceFileCodeSyntaxKinds.BaseNamespaceDeclaration.Contains(s.Kind()))
                            .OfType<BaseNamespaceDeclarationSyntax>()
                            .SelectMany(s => s.Members
                                .Where(s => s.IsKind(SyntaxKind.ClassDeclaration))
                                .OfType<ClassDeclarationSyntax>()
                                .Where(s => s.Identifier.ToFullString().Contains("ExecuteLegacy")) // 仅扫描旧版 API
                            )
                            .SelectMany(s => s.Members
                                .Where(s => s.IsKind(SyntaxKind.MethodDeclaration))
                                .OfType<MethodDeclarationSyntax>()
                            )
                            .Where(s =>
                            {
                                string methodName = s.Identifier.ToFullString().Trim();
                                return methodName.StartsWith("Execute") &&
                                       methodName.EndsWith("Async");
                            })
                            .ToArray();
                        foreach (MethodDeclarationSyntax syntaxMethodDeclarationNode in syntaxMethodDeclarationNodes)
                        {
                            string methodName = syntaxMethodDeclarationNode.Identifier.ToFullString().Trim();

                            ExecutingMethodUrlPathSegmentsSyntaxWalker syntaxWalker = new ExecutingMethodUrlPathSegmentsSyntaxWalker();
                            syntaxWalker.Reset().Visit(syntaxMethodDeclarationNode);

                            string[] urlPathSegments1 = syntaxWalker.Result1 ?? Array.Empty<string>();
                            string[] urlPathSegments2 = syntaxWalker.Result2 ?? Array.Empty<string>();
                            for (int i = 0, len = Math.Max(urlPathSegments1.Length, urlPathSegments1.Length); i < len; i++)
                            {
                                string? s1 = urlPathSegments1.Length > i ? urlPathSegments1[i] : null;
                                string? s2 = urlPathSegments2.Length > i ? urlPathSegments2[i] : null;
                                if (!string.Equals(s1, s2))
                                    throw new AnalysisException($"文件 \"{cur.FileInfo.FullName}\"下的函数 \"{methodName}\" 应是一个 API 接口方法、且适配旧版入口点，但其 URL 路径的代码实现存在冲突。（Expected: \"{"/" + string.Join("/", urlPathSegments1)}\", Actual: \"{"/" + string.Join("/", urlPathSegments2)}\"）");
                            }
                        }
                    })
                    .AssertNoIssues();
            }));
        }

        private void CodeAnalyze_ExtendedSDK_ProductApi()
        {
            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppProductApiClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Events",
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true,
                    ThrowOnNotFoundWebhookEventTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppProductApiClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Events",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.ByteDance.MicroApp/"),
                    ProjectSourceRequestModelClassCodeSubDirectory = "ExtendedSDK/ProductApi/Models/",
                    ProjectSourceResponseModelClassCodeSubDirectory = "ExtendedSDK/ProductApi/Models/",
                    ProjectSourceExecutingExtensionClassCodeSubDirectory = "ExtendedSDK/ProductApi/Extensions/",
                    ProjectSourceWebhookEventClassCodeSubDirectory = "ExtendedSDK/ProductApi/Events/",
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests/"),
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/ProductApi/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/ProductApi/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/ProductApi/",
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundWebhookEventClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true,
                    ThrowOnNotFoundWebhookEventSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options).AssertNoIssues();
            }));
        }

        private void CodeAnalyze_ExtendedSDK_RoleApi()
        {
            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppRoleApiClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi",
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppRoleApiClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.ByteDance.MicroApp/"),
                    ProjectSourceRequestModelClassCodeSubDirectory = "ExtendedSDK/RoleApi/Models/",
                    ProjectSourceResponseModelClassCodeSubDirectory = "ExtendedSDK/RoleApi/Models/",
                    ProjectSourceExecutingExtensionClassCodeSubDirectory = "ExtendedSDK/RoleApi/Extensions/",
                    ProjectSourceWebhookEventClassCodeSubDirectory = "ExtendedSDK/RoleApi/Events/",
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests/"),
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/RoleApi/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/RoleApi/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/RoleApi/",
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options).AssertNoIssues();
            }));
        }

        private void CodeAnalyze_ExtendedSDK_Webcast()
        {
            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppWebcastClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast",
                    ThrowOnNotFoundRequestModelTypes = true,
                    ThrowOnNotFoundResponseModelTypes = true,
                    ThrowOnNotFoundExecutingExtensionTypes = true
                };
                new TypeDeclarationAnalyzer(options).AssertNoIssues();
            }));

            Assert.Null(Record.Exception(() =>
            {
                string workdir = Environment.CurrentDirectory;
                string projdir = Path.Combine(workdir, "../../../../../");

                var options = new SourceFileAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppWebcastClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.ByteDance.MicroApp/"),
                    ProjectSourceRequestModelClassCodeSubDirectory = "ExtendedSDK/Webcast/Models/",
                    ProjectSourceResponseModelClassCodeSubDirectory = "ExtendedSDK/Webcast/Models/",
                    ProjectSourceExecutingExtensionClassCodeSubDirectory = "ExtendedSDK/Webcast/Extensions/",
                    ProjectSourceWebhookEventClassCodeSubDirectory = "ExtendedSDK/Webcast/Events/",
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests/"),
                    ProjectTestRequestModelSerializationSampleSubDirectory = "ModelSamples/Webcast/",
                    ProjectTestResponseModelSerializationSampleSubDirectory = "ModelSamples/Webcast/",
                    ProjectTestWebhookEventSerializationSampleSubDirectory = "EventSamples/Webcast/",
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options).AssertNoIssues();
            }));
        }

        private class ExecutingMethodUrlPathSegmentsSyntaxWalker : CSharpSyntaxWalker
        {
            public string[]? Result1 { get; private set; }

            public string[]? Result2 { get; private set; }

            public ExecutingMethodUrlPathSegmentsSyntaxWalker Reset()
            {
                Result1 = null;
                Result2 = null;
                return this;
            }

            public override void VisitInvocationExpression(InvocationExpressionSyntax node)
            {
                if (node.Expression is MemberAccessExpressionSyntax memberAccessExpressionSyntaxNode)
                {
                    if (node.ToFullString().Contains("CreateFlurlRequest") && node.ArgumentList?.Arguments.Count >= 3)
                    {
                        string arg1 = node.ArgumentList.Arguments[0].ToFullString();
                        string arg2 = node.ArgumentList.Arguments[1].ToFullString();
                        if (arg1 is not null && arg2.Contains(nameof(HttpMethod)))
                        {
                            Result1 ??= node.ArgumentList.Arguments
                                .Skip(2)
                                .Select(s => FormatArgument(s.ToFullString()))
                                .ToArray();
                        }
                    }
                    else if (node.ToFullString().Contains("WithUrl") && node.ArgumentList?.Arguments.Count >= 1)
                    {
                        string arg1 = node.ArgumentList.Arguments[0].ToFullString();
                        if (arg1 is not null && arg1.Contains("AppendPathSegments"))
                        {
                            Result2 ??= node.ArgumentList.Arguments[0].Expression
                                .ChildNodes()
                                .Where(s => s.IsKind(SyntaxKind.InvocationExpression))
                                .OfType<InvocationExpressionSyntax>()
                                .SelectMany(s => s.ChildNodes()
                                    .Where(s => s.IsKind(SyntaxKind.ArgumentList))
                                    .OfType<ArgumentListSyntax>()
                                )
                                .SelectMany(s => s.ChildNodes()
                                    .Where(s => s.IsKind(SyntaxKind.Argument))
                                    .OfType<ArgumentSyntax>()
                                )
                                .Select(s => FormatArgument(s.ToFullString()))
                                .ToArray();
                        }
                    }
                }

                base.VisitInvocationExpression(node);
            }

            private string FormatArgument(string arg)
            {
                if (arg.StartsWith("\"") && arg.EndsWith("\""))
                    return arg.Trim('\"');

                if (arg == "string.Empty")
                    return string.Empty;

                return "{" + arg + "}";
            }
        }
    }
}
