using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.UnitTests
{
    public class TestCase_ApiExecuteTokenTests
    {
        [Fact(DisplayName = "测试用例：调用 API [POST] /token/create")]
        public async Task TestExecuteTokenCreate()
        {
            var request = new Models.TokenCreateRequest()
            {
                Code = "TEST_CODE"
            };
            var response = await TestClients.Instance.ExecuteTokenCreateAsync(request);

            Assert.True(response.IsSuccessful());
            Assert.NotNull(response.Data);
            Assert.NotEmpty(response.Data.AccessToken);
            Assert.True(response.Data.ExpiresIn > 0);
        }
    }
}
