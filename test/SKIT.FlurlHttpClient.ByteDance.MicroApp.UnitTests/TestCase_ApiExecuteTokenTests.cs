using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    public class TestCase_ApiExecuteTokenTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /token/create")]
        public async Task TokenCreateTest()
        {
            var request = new Models.AppsTokenRequest();
            var response = await TestClients.Instance.ExecuteAppsTokenAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.AccessToken);
            Assert.True(response.ExpiresIn > 0);
        }
    }
}
