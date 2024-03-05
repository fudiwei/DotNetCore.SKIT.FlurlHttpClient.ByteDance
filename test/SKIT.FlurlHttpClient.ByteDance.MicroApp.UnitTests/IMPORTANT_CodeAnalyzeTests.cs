using System;
using System.IO;
using System.Reflection;
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
                () => Assert.Null(Record.Exception(() =>
                {
                    var options = new TypeDeclarationAnalyzerOptions()
                    {
                        SdkAssembly = Assembly.GetAssembly(typeof(DouyinMicroAppClient))!,
                        SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.Models",
                        SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.Models",
                        SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp",
                        SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.MicroApp.Events",
                        IgnoreExecutingExtensionTypes = static type => type.Namespace.Contains(".ExtendedSDK."),
                        ThrowOnNotFoundRequestModelTypes = true,
                        ThrowOnNotFoundResponseModelTypes = true,
                        ThrowOnNotFoundExecutingExtensionTypes = true,
                        ThrowOnNotFoundWebhookEventTypes = true
                    };
                    new TypeDeclarationAnalyzer(options).AssertNoIssues();
                })),

                () => Assert.Null(Record.Exception(() =>
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
                    new SourceFileAnalyzer(options).AssertNoIssues();
                }))
            );

            Assert.Multiple(
                () => Assert.Null(Record.Exception(() =>
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
                })),

                () => Assert.Null(Record.Exception(() =>
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
                    new SourceFileAnalyzer(options).AssertNoIssues();
                }))
            );

            Assert.Multiple(
                () => Assert.Null(Record.Exception(() =>
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
                })),

                () => Assert.Null(Record.Exception(() =>
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
                }))
            );

            Assert.Multiple(
                () => Assert.Null(Record.Exception(() =>
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
                })),

                () => Assert.Null(Record.Exception(() =>
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
                }))
            );

            Assert.Multiple(
                () => Assert.Null(Record.Exception(() =>
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
                })),

                () => Assert.Null(Record.Exception(() =>
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
                }))
            );
        }
    }
}
