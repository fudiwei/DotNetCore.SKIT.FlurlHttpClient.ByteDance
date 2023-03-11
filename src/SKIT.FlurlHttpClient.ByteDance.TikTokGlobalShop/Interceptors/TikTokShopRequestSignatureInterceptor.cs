using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Interceptors
{
    internal class TikTokShopRequestSignatureInterceptor : FlurlHttpCallInterceptor
    {
        private readonly string _baseUrl;
        private readonly string _appSecret;

        public TikTokShopRequestSignatureInterceptor(string baseUrl, string appSecret)
        {
            _baseUrl = baseUrl;
            _appSecret = appSecret;
        }

        public override Task BeforeCallAsync(FlurlCall flurlCall)
        {
            if (flurlCall == null) throw new ArgumentNullException(nameof(flurlCall));
            if (flurlCall.Completed) throw new Exceptions.TikTokShopRequestSignatureException("This interceptor must be called before request completed.");

            string requestUrl = flurlCall.HttpRequestMessage.RequestUri?.ToString() ?? string.Empty;
            if (!requestUrl.StartsWith(_baseUrl, StringComparison.OrdinalIgnoreCase))
            {
                // 非基地址的请求跳过签名（如 Auth API）
                return Task.CompletedTask;
            }

            IList<string> ignoreQueryNames = new List<string>();
            string signText;

            try
            {
                var queryParams = new QueryParamCollection(flurlCall.HttpRequestMessage.RequestUri!.Query);
                queryParams.Remove("access_token");
                queryParams.Remove("sign");

                string msgText = string.Format(
                    "{0}{1}{2}",
                    arg0: _appSecret,
                    arg1: flurlCall.HttpRequestMessage.RequestUri.AbsolutePath,
                    arg2: string.Join(string.Empty, queryParams
                        .ToDictionary(k => k.Name, v => v.Value.ToString())
                        .OrderBy(k => k.Key, StringComparer.Ordinal)
                        .Where(e =>
                        {
                            if (string.IsNullOrEmpty(e.Value))
                            {
                                // 过滤空参数，空参数不参与签名
                                ignoreQueryNames.Add(e.Key);
                                return false;
                            }

                            return true;
                        })
                        .Select(e => $"{e.Key}{e.Value}")
                    )
                );
                signText = Utilities.HMACUtility.HashWithSHA256(_appSecret, msgText);
            }
            catch (Exception ex)
            {
                throw new Exceptions.TikTokShopRequestSignatureException("Failed to generate signature of request. Please see the inner exception for more details.", ex);
            }

            flurlCall.Request.SetQueryParam("sign", signText);
            flurlCall.Request.RemoveQueryParams(ignoreQueryNames);
            return Task.CompletedTask;
        }
    }
}
