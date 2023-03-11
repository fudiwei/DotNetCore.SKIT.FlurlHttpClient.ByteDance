using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    /// <summary>
    /// 一个抖店开放平台 API HTTP 客户端。
    /// </summary>
    public class DouyinShopClient : CommonClientBase, ICommonClient
    {
        /// <summary>
        /// 获取当前客户端使用的抖店开放平台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="DouyinShopClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public DouyinShopClient(DouyinShopClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoint ?? DouyinShopEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.DouyinShopRequestFormatInterceptor());
            Interceptors.Add(new Interceptors.DouyinShopRequestSignInterceptor(
                baseUrl: FlurlClient.BaseUrl,
                appKey: options.AppKey,
                appSecret: options.AppSecret,
                signMethod: options.SignAlgorithm
            ));
        }

        /// <summary>
        /// 用指定的抖店开放平台应用 Key、抖店开放平台应用密钥初始化 <see cref="DouyinShopClient"/> 类的新实例。
        /// </summary>
        /// <param name="appKey">抖店开放平台应用 Key。</param>
        /// <param name="appSecret">抖店开放平台应用密钥。</param>
        public DouyinShopClient(string appKey, string appSecret)
            : this(new DouyinShopClientOptions() { AppKey = appKey, AppSecret = appSecret })
        {
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(DouyinShopRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (request.Timeout != null)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            if (request.ApiMethod == null)
            {
                flurlRequest.SetQueryParam("method", request.ApiMethod);
            }

            if (request.ApiVersion == null)
            {
                flurlRequest.SetQueryParam("v", request.ApiVersion);
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
            where T : DouyinShopResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new Exceptions.DouyinShopRequestTimeoutException(ex.Message, ex);
            }
            catch (FlurlHttpException ex)
            {
                throw new DouyinShopException(ex.Message, ex);
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
            where T : DouyinShopResponse, new()
        {
            if (flurlRequest == null) throw new ArgumentNullException(nameof(flurlRequest));

            try
            {
                bool isSimpleRequest = data == null ||
                    flurlRequest.Verb == HttpMethod.Get ||
                    flurlRequest.Verb == HttpMethod.Head ||
                    flurlRequest.Verb == HttpMethod.Options;
                using IFlurlResponse flurlResponse = isSimpleRequest ?
                    await base.SendRequestAsync(flurlRequest, null, cancellationToken) :
                    await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken);
                return await WrapResponseWithJsonAsync<T>(flurlResponse, cancellationToken);
            }
            catch (FlurlHttpTimeoutException ex)
            {
                throw new Exceptions.DouyinShopRequestTimeoutException(ex.Message, ex);
            }
            catch (FlurlHttpException ex)
            {
                throw new DouyinShopException(ex.Message, ex);
            }
        }
    }
}
