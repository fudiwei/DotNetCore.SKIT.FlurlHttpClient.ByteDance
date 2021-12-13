using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 一个字节小程序 API HTTP 客户端。
    /// </summary>
    public class ByteDanceMicroAppClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的字节小程序凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="ByteDanceMicroAppClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public ByteDanceMicroAppClient(ByteDanceMicroAppClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoints ?? ByteDanceMicroAppEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));
        }

        /// <summary>
        /// 用指定的字节小程序应用 Key、字节小程序应用密钥初始化 <see cref="ByteDanceMicroAppClient"/> 类的新实例。
        /// </summary>
        /// <param name="appKey">字节小程序应用 Key。</param>
        /// <param name="appSecret">字节小程序 。</param>
        public ByteDanceMicroAppClient(string appKey, string appSecret)
            : this(new ByteDanceMicroAppClientOptions() { AppId = appKey, AppSecret = appSecret })
        {
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(ByteDanceMicroAppRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (request.Timeout != null)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            return flurlRequest;
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="httpContent"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : ByteDanceMicroAppResponse, new()
        {
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new ByteDanceMicroAppException(ex.Message, ex);
            }
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : ByteDanceMicroAppResponse, new()
        {
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new ByteDanceMicroAppException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse flurlResponse)
            where T : ByteDanceMicroAppResponse, new()
        {
            byte[] bytes = await flurlResponse.GetBytesAsync().ConfigureAwait(false);
            bool jsonable =
                (bytes.Length > 1 && bytes[0] == 91 && bytes[bytes.Length - 1] == 93) || // "[...]"
                (bytes.Length > 1 && bytes[0] == 123 && bytes[bytes.Length - 1] == 125); // "{...}"
            T result = jsonable ? JsonSerializer.Deserialize<T>(Encoding.UTF8.GetString(bytes)) : new T();

            result.RawStatus = flurlResponse.StatusCode;
            result.RawHeaders = new ReadOnlyDictionary<string, string>(
                flurlResponse.Headers
                    .GroupBy(e => e.Name)
                    .ToDictionary(
                        k => k.Key,
                        v => string.Join(", ", v.Select(e => e.Value))
                    )
            );
            result.RawBytes = bytes;

            return result;
        }
    }
}
