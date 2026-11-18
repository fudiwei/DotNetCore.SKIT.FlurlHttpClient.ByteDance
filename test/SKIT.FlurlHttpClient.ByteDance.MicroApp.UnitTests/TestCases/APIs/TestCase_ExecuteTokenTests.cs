namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests.TestCases.APIs
{
    public class TestCase_ApiExecuteTokenTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /token/v2/create）")]
        public async Task TestExecuteAppsTokenV2()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_AppId, "【已跳过】未配置 \"Credentials.AppId\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_AppSecret, "【已跳过】未配置 \"Credentials.AppSecret\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.AppsTokenV2Request();
            var response = await client.ExecuteAppsTokenV2Async(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.Data.AccessToken);
            Assert.True(response.Data.ExpiresIn > 0);
        }
    }
}
