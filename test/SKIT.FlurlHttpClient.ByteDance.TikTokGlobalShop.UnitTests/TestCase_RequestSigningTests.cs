using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.UnitTests
{
    public partial class TestCase_RequestSigningTests
    {
        [Fact(DisplayName = "测试用例：即时配送请求签名")]
        public async Task TestRequestSignature()
        {
            var mockClient = TikTokShopClientBuilder
                .Create(new TikTokShopClientOptions()
                {
                    AppKey = "68xu9ks5p4i8",
                    AppSecret = "e59af819cc"
                })
                .UseHttpClient(new MockHttpClient())
                .Build();

            // Sign GET request
            {
                var request = new Models.EventGetWebhooksRequest()
                {
                    ShopCipher = "ROW_xkMbgAAAeVAQra0eZWebFQq5aIK",
                    Timestamp = 1696909648,
                    ApiVersion = 202309
                };
                var response = await mockClient.ExecuteEventGetWebhooksAsync(request);

                Assert.Equal("ed58e1b5e59865c22a7b828c1cab65007441f43cc91a6cb2f2cdc638e0995a37", response.GetRawHeaders().GetFirstValueOrEmpty(MOCK_HEADER_NAME), ignoreCase: true);
            }

            // Sign non-GET request
            {
                var request = new Models.EventUpdateWebhookRequest()
                {
                    ShopCipher = "ROW_xkMbgAAAeVAQra0eZWebFQq5aIK",
                    Timestamp = 1696909648,
                    ApiVersion = 202309,
                    EventType = "PACKAGE_UPDATE",
                    WebhookUrl = "https://partner.tiktokshop.com"
                };
                var response = await mockClient.ExecuteEventUpdateWebhookAsync(request);

                Assert.Equal("701dd6deb2389fe4c469b89bd37fc56f96a6da6afeb4d01c9077a65169752fa7", response.GetRawHeaders().GetFirstValueOrEmpty(MOCK_HEADER_NAME), ignoreCase: true);
            }
        }
    }

    partial class TestCase_RequestSigningTests
    {
        private const string MOCK_HEADER_NAME = "Mock-Sign";

        public class MockHttpClient : HttpClient
        {
            public MockHttpClient()
                : base(new MockHttpMessageHandler(new HttpClientHandler()))
            {
            }
        }

        public class MockHttpMessageHandler : DelegatingHandler
        {
            public MockHttpMessageHandler(HttpMessageHandler innerHandler)
                : base(innerHandler)
            {
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var resp = new HttpResponseMessage
                {
                    RequestMessage = request,
                    StatusCode = HttpStatusCode.NoContent,
                    Content = new ByteArrayContent(Array.Empty<byte>()),
                };
                var queryParams = new QueryParamCollection(request.RequestUri?.Query);
                resp.Headers.TryAddWithoutValidation(MOCK_HEADER_NAME, string.Join(",", queryParams.GetAll("sign")));
                return Task.FromResult(resp);
            }
        }
    }
}
