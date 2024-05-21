using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Interceptors
{
    using SKIT.FlurlHttpClient.Internal;

    internal class DouyinMicroAppWebcastRequestSigningInterceptor : HttpInterceptor
    {
        private readonly string _appId;
        private readonly string _pkVersion;
        private readonly string _pkPem;

        public DouyinMicroAppWebcastRequestSigningInterceptor(string appId, string pkVersion, string pkPem)
        {
            _appId = appId;
            _pkVersion = pkVersion;
            _pkPem = pkPem;
        }

        public override async Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new DouyinMicroAppException("Failed to sign request. This interceptor must be called before request completed.");

            string method = context.FlurlCall.HttpRequestMessage.Method.ToString().ToUpper();
            string url = context.FlurlCall.HttpRequestMessage.RequestUri?.PathAndQuery ?? string.Empty;
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string body = string.Empty;

            if (context.FlurlCall.HttpRequestMessage?.Content is not null)
            {
                if (context.FlurlCall.HttpRequestMessage.Content is MultipartFormDataContent)
                {
                    // noop!
                }
                else if (method != "GET")
                {
                    HttpContent httpContent = context.FlurlCall.HttpRequestMessage.Content;
                    body = await _AsyncEx.RunTaskWithCancellationTokenAsync(httpContent.ReadAsStringAsync(), cancellationToken).ConfigureAwait(false);
                }
            }

            string signData = $"{method}\n{url}\n{timestamp}\n{nonce}\n{body}\n";
            string sign;

            try
            {
                sign = Utilities.RSAUtility.SignWithSHA256(_pkPem, signData).Value!;
            }
            catch (Exception ex)
            {
                throw new DouyinMicroAppException("Failed to sign request. Please see the inner exception for more details.", ex);
            }

            context.FlurlCall.Request.WithHeader("Byte-Authorization", $"SHA256-RSA2048 appid=\"{_appId}\",nonce_str=\"{nonce}\",timestamp=\"{timestamp}\",key_version=\"{_pkVersion}\",signature=\"{sign}\"");
        }
    }
}
