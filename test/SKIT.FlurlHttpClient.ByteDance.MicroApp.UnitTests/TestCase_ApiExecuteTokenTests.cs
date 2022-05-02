using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    public class TestCase_ApiExecuteTokenTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /token/v2/create")]
        public async Task TestExecuteV2TokenCreate()
        {
            var request = new Models.AppsV2TokenRequest();
            var response = await TestClients.Instance.ExecuteAppsV2TokenAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotEmpty(response.Data.AccessToken);
            Assert.True(response.Data.ExpiresIn > 0);
        }
    }
}
