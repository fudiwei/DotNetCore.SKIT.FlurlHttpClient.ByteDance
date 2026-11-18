using System.Net;
using System.Net.Http;
using System.Text;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests.TestCases
{
    public partial class TestCase_RequestSigningTests
    {
        [Fact(DisplayName = "测试用例：担保支付相关接口请求签名")]
        public async Task TestECPayRequestSigning()
        {
            using var httpClient = new MockHttpClient();
            using var mockClient = new DouyinMicroAppClient(new DouyinMicroAppClientOptions()
            {
                AppId = "",
                AppSecret = "",
                ECPaySalt = "your_payment_salt"
            }, httpClient);

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
            _ = await mockClient.ExecuteAppsECPayCreateOrderV1Async(request, TestContext.Current.CancellationToken);

            Assert.Equal("54f102e7115f8a6a3e6af4633dc33959", request.Signature, ignoreCase: true);
        }
    }

    partial class TestCase_RequestSigningTests
    {
        private sealed class MockHttpClient : HttpClient
        {
            public MockHttpClient()
                : base(new MockHttpMessageHandler(new HttpClientHandler()))
            {
            }
        }

        private sealed class MockHttpMessageHandler : DelegatingHandler
        {
            public MockHttpMessageHandler(HttpMessageHandler innerHandler)
                : base(innerHandler)
            {
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                string mockResponseContent = "{\"err_no\": 0, \"err_msg\": \"ok\"}";
                byte[] mockResponseBytes = Encoding.UTF8.GetBytes(mockResponseContent);
                var resp = new HttpResponseMessage
                {
                    RequestMessage = request,
                    StatusCode = HttpStatusCode.NoContent,
                    Content = new ByteArrayContent(mockResponseBytes),
                };
                resp.Headers.TryAddWithoutValidation("Content-Length", mockResponseBytes.Length.ToString());
                return Task.FromResult(resp);
            }
        }
    }
}
