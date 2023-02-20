using SKIT.FlurlHttpClient.Tools.CodeAnalyzer;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    public class TestCase_CodeReview
    {
        [Fact(DisplayName = "测试用例：代码质量分析")]
        public void TestCodeAnalyzer()
        {
            Assert.Null(Record.Exception(() =>
            {
                CodeAnalyzerOptions options = new CodeAnalyzerOptions()
                {
                    AssemblyName = "SKIT.FlurlHttpClient.ByteDance.MicroApp",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    WorkSubDirectoryForApiModelSamples = "ModelSamples/_",
                    WorkSubDirectoryForApiEventSamples = "EventSamples/_",
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));

            Assert.Null(Record.Exception(() =>
            {
                CodeAnalyzerOptions options = new CodeAnalyzerOptions()
                {
                    AssemblyName = "SKIT.FlurlHttpClient.ByteDance.MicroApp",
                    TargetSdkApiModelNamespaceUnderAssemblyIdentifier = "SDK.ProductApi.Models",
                    TargetSdkApiEventNamespaceUnderAssemblyIdentifier = "SDK.ProductApi.Events",
                    //TargetSdkApiMethodNamespaceUnderAssemblyIdentifier = "SDK.ProductApi",
                    WorkDirectoryForSourceCode = TestConfigs.WorkDirectoryForSdk,
                    WorkDirectoryForTestSample = TestConfigs.WorkDirectoryForTest,
                    WorkSubDirectoryForApiMethods = "SDK/ProductApi/Extensions",
                    WorkSubDirectoryForApiModels = "SDK/ProductApi/Models",
                    WorkSubDirectoryForApiEvents = "SDK/ProductApi/Events",
                    WorkSubDirectoryForApiModelSamples = "ModelSamples/ProductApi",
                    WorkSubDirectoryForApiEventSamples = "EventSamples/ProductApi"
                };
                CodeAnalyzer analyzer = new CodeAnalyzer(options);
                analyzer.Start();
                analyzer.Assert();
                analyzer.Flush();
            }));
        }
    }
}
