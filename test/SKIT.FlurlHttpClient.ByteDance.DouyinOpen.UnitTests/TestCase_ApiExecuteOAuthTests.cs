using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.UnitTests
{
    public class TestCase_ApiExecuteOAuthTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /oauth/client_token")]
        public async Task TestExecuteOAuthClientToken()
        {
            var request = new Models.OAuthClientTokenRequest();
            var response = await TestClients.Instance.ExecuteOAuthClientTokenAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.Data.AccessToken);
            Assert.True(response.Data.ExpiresIn > 0);
        }
    }
}
