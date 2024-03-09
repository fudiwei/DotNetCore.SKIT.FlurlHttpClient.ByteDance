using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi
{
    /// <summary>
    /// 用于构造 <see cref="DouyinMicroAppProductApiClient"/> 实例的构造器。
    /// </summary>
    public partial class DouyinMicroAppProductApiClientBuilder : ICommonClientBuilder<DouyinMicroAppProductApiClient>
    {
        private readonly DouyinMicroAppProductApiClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private DouyinMicroAppProductApiClientBuilder(DouyinMicroAppProductApiClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<DouyinMicroAppProductApiClient> ICommonClientBuilder<DouyinMicroAppProductApiClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<DouyinMicroAppProductApiClient> ICommonClientBuilder<DouyinMicroAppProductApiClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<DouyinMicroAppProductApiClient> ICommonClientBuilder<DouyinMicroAppProductApiClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public DouyinMicroAppProductApiClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public DouyinMicroAppProductApiClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public DouyinMicroAppProductApiClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public DouyinMicroAppProductApiClient Build()
        {
            DouyinMicroAppProductApiClient client = _disposeClient.HasValue
                ? new DouyinMicroAppProductApiClient(_options, _httpClient, _disposeClient.Value)
                : new DouyinMicroAppProductApiClient(_options, _httpClient);

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

    partial class DouyinMicroAppProductApiClientBuilder
    {
        public static DouyinMicroAppProductApiClientBuilder Create(DouyinMicroAppProductApiClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new DouyinMicroAppProductApiClientBuilder(options);
        }
    }
}
