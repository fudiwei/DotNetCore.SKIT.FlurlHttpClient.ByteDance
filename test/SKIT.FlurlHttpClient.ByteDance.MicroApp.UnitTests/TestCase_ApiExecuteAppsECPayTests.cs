using System.Threading.Tasks;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    public class TestCase_ApiExecuteAppsECPayTests
    {
        [Fact(DisplayName = "测试用例：担保支付请求签名")]
        public async Task TestECPayRequestSignature()
        {
            using var client = new DouyinMicroAppClient(new DouyinMicroAppClientOptions() { ECPaySalt = "your_payment_salt" });
            var request = new Models.AppsECPayCreateOrderV1Request()
            {
                AppId = "ttcfdbb9xxxxxxxxxxx",
                ComponentAppId = "tta4bad200000xxxxxx",
                OutTradeNumber = "test-02167569xxxxxx",
                TotalAmount = 2376,
                Subject = "test-payment_subject-test-paym...",
                Body = "强烈推荐！经典腊汁肉夹馍团购价仅需7.92元！",
                ValidTime = 172800,
                NotifyUrl = "https://www.xxx.com",
                IsMessageDisabled = false,
                MessagePagePath = "pages/user/orderDetail/orderDetail?id=997979879879879879"
            };
            _ = await client.ExecuteAppsECPayCreateOrderV1Async(request);
            Assert.Equal("54f102e7115f8a6a3e6af4633dc33959", request.Signature, ignoreCase: true);
        }
    }
}
