namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.UnitTests.TestCases.APIs
{
    public class TestCase_ExecuteOAuthTests
    {
        [Fact(DisplayName = "测试用例：调用 API（[POST] /oauth/client_token）")]
        public async Task TestExecuteOAuthClientToken()
        {
            Assert.SkipWhen("" == ITConfigs.Credentials_ClientKey, "【已跳过】未配置 \"Credentials.ClientKey\"。");
            Assert.SkipWhen("" == ITConfigs.Credentials_ClientSecret, "【已跳过】未配置 \"Credentials.ClientSecret\"。");

            using var client = ITClients.CreateInstance();
            var request = new Models.OAuthClientTokenRequest();
            var response = await client.ExecuteOAuthClientTokenAsync(request, TestContext.Current.CancellationToken);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.Data.AccessToken);
            Assert.True(response.Data.ExpiresIn > 0);
        }
    }
}
