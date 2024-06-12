using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Interceptors
{
    using SKIT.FlurlHttpClient.Internal;

    internal class TikTokShopRequestSigningInterceptor : HttpInterceptor
    {
        private readonly string _baseUrl;
        private readonly string _appSecret;

        public TikTokShopRequestSigningInterceptor(string baseUrl, string appSecret)
        {
            _baseUrl = baseUrl.TrimEnd('/');
            _appSecret = appSecret;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new TikTokShopException("Failed to sign request. This interceptor must be called before request completed.");

            string requestUrl = context.FlurlCall.HttpRequestMessage.RequestUri?.ToString() ?? string.Empty;
            if (!requestUrl.StartsWith(_baseUrl, StringComparison.OrdinalIgnoreCase))
            {
                // 非基地址的请求跳过签名（如 Auth API）
                return;
            }

            string body = string.Empty;
            if (context.FlurlCall.HttpRequestMessage?.Content is not null)
            {
                if (context.FlurlCall.HttpRequestMessage.Method != HttpMethod.Get &&
                    context.FlurlCall.HttpRequestMessage.Content is not MultipartFormDataContent)
                {
                    HttpContent httpContent = context.FlurlCall.HttpRequestMessage.Content;
                    body = await _AsyncEx.RunTaskWithCancellationTokenAsync(httpContent.ReadAsStringAsync(), cancellationToken).ConfigureAwait(false);
                }
            }

            string signature;

            try
            {
                var queryParams = new QueryParamCollection(context.FlurlCall.HttpRequestMessage?.RequestUri?.Query);
                queryParams.Remove("access_token");
                queryParams.Remove("sign");

                string msgText = string.Format(
                    "{0}{1}{2}{3}{4}",
                    _appSecret,
                    context.FlurlCall.HttpRequestMessage?.RequestUri?.AbsolutePath,
                    string.Join(string.Empty, queryParams
                        .ToDictionary(k => k.Name, v => v.Value.ToString())
                        .OrderBy(k => k.Key, StringComparer.Ordinal)
                        .Where(e =>
                        {
                            if (string.IsNullOrEmpty(e.Value))
                            {
                                // 过滤空参数，空参数不参与签名
                                context.FlurlCall.Request.RemoveQueryParam(e.Key);
                                return false;
                            }

                            return true;
                        })
                        .Select(e => $"{e.Key}{e.Value}")
                    ),
                    body,
                    _appSecret
                );
                signature = Utilities.HMACUtility.HashWithSHA256(_appSecret, msgText).Value!;
            }
            catch (Exception ex)
            {
                throw new TikTokShopException("Failed to sign request. Please see the inner exception for more details.", ex);
            }

            context.FlurlCall.Request.SetQueryParam("sign", signature);
        }
    }
}
