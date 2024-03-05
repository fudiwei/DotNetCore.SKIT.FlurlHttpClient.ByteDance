using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    /// <summary>
    /// 用于构造 <see cref="DouyinMicroAppWebcastClient"/> 实例的构造器。
    /// </summary>
    public partial class DouyinMicroAppWebcastClientBuilder : ICommonClientBuilder<DouyinMicroAppWebcastClient>
    {
        private readonly DouyinMicroAppWebcastClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private DouyinMicroAppWebcastClientBuilder(DouyinMicroAppWebcastClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<DouyinMicroAppWebcastClient> ICommonClientBuilder<DouyinMicroAppWebcastClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<DouyinMicroAppWebcastClient> ICommonClientBuilder<DouyinMicroAppWebcastClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<DouyinMicroAppWebcastClient> ICommonClientBuilder<DouyinMicroAppWebcastClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public DouyinMicroAppWebcastClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public DouyinMicroAppWebcastClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public DouyinMicroAppWebcastClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public DouyinMicroAppWebcastClient Build()
        {
            DouyinMicroAppWebcastClient client = _disposeClient.HasValue
                ? new DouyinMicroAppWebcastClient(_options, _httpClient, _disposeClient.Value)
                : new DouyinMicroAppWebcastClient(_options, _httpClient);

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

    partial class DouyinMicroAppWebcastClientBuilder
    {
        public static DouyinMicroAppWebcastClientBuilder Create(DouyinMicroAppWebcastClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new DouyinMicroAppWebcastClientBuilder(options);
        }
    }
}
