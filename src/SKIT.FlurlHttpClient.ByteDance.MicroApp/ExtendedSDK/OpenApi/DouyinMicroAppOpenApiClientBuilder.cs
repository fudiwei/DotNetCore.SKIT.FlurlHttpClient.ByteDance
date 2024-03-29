using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    /// <summary>
    /// 用于构造 <see cref="DouyinMicroAppOpenApiClient"/> 实例的构造器。
    /// </summary>
    public partial class DouyinMicroAppOpenApiClientBuilder : ICommonClientBuilder<DouyinMicroAppOpenApiClient>
    {
        private readonly DouyinMicroAppOpenApiClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private DouyinMicroAppOpenApiClientBuilder(DouyinMicroAppOpenApiClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<DouyinMicroAppOpenApiClient> ICommonClientBuilder<DouyinMicroAppOpenApiClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<DouyinMicroAppOpenApiClient> ICommonClientBuilder<DouyinMicroAppOpenApiClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<DouyinMicroAppOpenApiClient> ICommonClientBuilder<DouyinMicroAppOpenApiClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public DouyinMicroAppOpenApiClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public DouyinMicroAppOpenApiClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public DouyinMicroAppOpenApiClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public DouyinMicroAppOpenApiClient Build()
        {
            DouyinMicroAppOpenApiClient client = _disposeClient.HasValue
                ? new DouyinMicroAppOpenApiClient(_options, _httpClient, _disposeClient.Value)
                : new DouyinMicroAppOpenApiClient(_options, _httpClient);

            foreach (Action<CommonClientSettings> configure in _configures)
            {
                client.Configure(configure);
            }

            foreach (HttpInterceptor interceptor in _interceptors)
            {
                client.Interceptors.Add(interceptor);
            }

            return client;
        }
    }

    partial class DouyinMicroAppOpenApiClientBuilder
    {
        public static DouyinMicroAppOpenApiClientBuilder Create(DouyinMicroAppOpenApiClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new DouyinMicroAppOpenApiClientBuilder(options);
        }
    }
}
