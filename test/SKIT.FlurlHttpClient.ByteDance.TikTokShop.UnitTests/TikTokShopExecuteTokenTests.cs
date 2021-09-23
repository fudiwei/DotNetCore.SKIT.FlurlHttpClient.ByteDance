using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.UnitTests
{
    public class TikTokShopExecuteTokenTests
    {
        [Fact(DisplayName = "[POST] /token/create")]
        public async Task TokenCreateTest()
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
