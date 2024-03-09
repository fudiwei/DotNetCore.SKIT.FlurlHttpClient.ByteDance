using System;
using System.IO;
using System.Reflection;
using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.UnitTests
{
    // NOTICE:
    //   如果 Visual Studio 遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
    //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

    public class IMPORTANT_CodeAnalyzeTests
    {
        [Fact(DisplayName = "测试用例：代码质量分析")]
        public void TestCodeAnalyzer()
        {
            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinOpenClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.DouyinOpen",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events",
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
                    SdkAssembly = Assembly.GetAssembly(typeof(DouyinOpenClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models",
                    SdkWebhookEventDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.ByteDance.DouyinOpen/"),
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.ByteDance.DouyinOpen.UnitTests/"),
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
    }
}
