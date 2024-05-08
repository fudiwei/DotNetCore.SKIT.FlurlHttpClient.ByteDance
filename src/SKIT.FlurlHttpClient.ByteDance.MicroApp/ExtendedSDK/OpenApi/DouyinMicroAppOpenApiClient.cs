using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    /// <summary>
    /// 一个抖音小程序服务商平台 API HTTP 客户端。
    /// </summary>
    public class DouyinMicroAppOpenApiClient : CommonClientBase, ICommonClient
    {
        public readonly string _BASEURL_LEGACY;

        /// <summary>
        /// 获取当前客户端使用的抖音小程序凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="DouyinMicroAppOpenApiClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public DouyinMicroAppOpenApiClient(DouyinMicroAppOpenApiClientOptions options)
            : this(options, null)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <param name="httpClient"></param>
        /// <param name="disposeClient"></param>
        internal protected DouyinMicroAppOpenApiClient(DouyinMicroAppOpenApiClientOptions options, HttpClient? httpClient, bool disposeClient = true)
            : base(httpClient, disposeClient)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoints ?? DouyinMicroAppOpenApiEndpoints.DEFAULT;
            FlurlClient.WithTimeout(options.Timeout <= 0 ? Timeout.InfiniteTimeSpan : TimeSpan.FromMilliseconds(options.Timeout));

            _BASEURL_LEGACY = options.EndpointForLegacy ?? DouyinMicroAppEndpoints.LEGACY_DEFAULT;
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="httpMethod"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateFlurlRequest(DouyinMicroAppOpenApiRequest request, HttpMethod httpMethod, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = base.CreateFlurlRequest(request, httpMethod, urlSegments);

            if (request.ComponentAppId is null)
            {
                request.ComponentAppId = Credentials.ComponentAppId;
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
        public async Task<T> SendFlurlRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : DouyinMicroAppOpenApiResponse, new()
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

            using IFlurlResponse flurlResponse = await base.SendFlurlRequestAsync(flurlRequest, httpContent, cancellationToken).ConfigureAwait(false);
            return await WrapFlurlResponseAsJsonAsync<T>(flurlResponse, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendFlurlRequestAsJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : DouyinMicroAppOpenApiResponse, new()
        {
            if (flurlRequest is null) throw new ArgumentNullException(nameof(flurlRequest));

            bool isSimpleRequest = data is null ||
                flurlRequest.Verb == HttpMethod.Get ||
                flurlRequest.Verb == HttpMethod.Head ||
                flurlRequest.Verb == HttpMethod.Options;
            if (!isSimpleRequest)
                flurlRequest.WithHeader(HttpHeaders.ContentType, MimeTypes.Json); // NOTICE: Content-Type 中不能包含 charset 等其他段

            using IFlurlResponse flurlResponse = isSimpleRequest ?
                await base.SendFlurlRequestAsync(flurlRequest, null, cancellationToken) :
                await base.SendFlurlRequestAsJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
            return await WrapFlurlResponseAsJsonAsync<T>(flurlResponse, cancellationToken).ConfigureAwait(false);
        }
    }
}
