using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    public class MicroAppExecuteTokenTests
    {
        [Fact(DisplayName = "[POST] /token/create")]
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
