using System;
using System.IO;
using System.Reflection;
using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.UnitTests
{
    public class CodeAnalyzeTests
    {
        // NOTICE:
        //   如果 Visual Studio 遇到 “缺少 SKIT.FlurlHttpClient.Tools.CodeAnalyzer 包” 的错误，
        //   请参考此 Issue：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient/issues/8

        [Fact(DisplayName = "代码质量分析")]
        public void CodeAnalyze()
        {
            Assert.Null(Record.Exception(() =>
            {
                var options = new TypeDeclarationAnalyzerOptions()
                {
                    SdkAssembly = Assembly.GetAssembly(typeof(TikTokShopClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models",
                    SdkExecutingExtensionDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop",
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
                    SdkAssembly = Assembly.GetAssembly(typeof(TikTokShopClient))!,
                    SdkRequestModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models",
                    SdkResponseModelDeclarationNamespace = "SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models",
                    ProjectSourceRootDirectory = Path.Combine(projdir, "./src/SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop/"),
                    ProjectTestRootDirectory = Path.Combine(projdir, "./test/SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.UnitTests/"),
                    ThrowOnNotFoundRequestModelClassCodeFiles = true,
                    ThrowOnNotFoundResponseModelClassCodeFiles = true,
                    ThrowOnNotFoundExecutingExtensionClassCodeFiles = true,
                    ThrowOnNotFoundRequestModelSerializationSampleFiles = true,
                    ThrowOnNotFoundResponseModelSerializationSampleFiles = true
                };
                new SourceFileAnalyzer(options).AssertNoIssues();
            }));
        }
    }
}
