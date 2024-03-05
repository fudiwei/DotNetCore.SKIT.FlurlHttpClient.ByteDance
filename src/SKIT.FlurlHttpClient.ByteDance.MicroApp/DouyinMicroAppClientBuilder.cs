using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 用于构造 <see cref="DouyinMicroAppClient"/> 实例的构造器。
    /// </summary>
    public partial class DouyinMicroAppClientBuilder : ICommonClientBuilder<DouyinMicroAppClient>
    {
        private readonly DouyinMicroAppClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private DouyinMicroAppClientBuilder(DouyinMicroAppClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<DouyinMicroAppClient> ICommonClientBuilder<DouyinMicroAppClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<DouyinMicroAppClient> ICommonClientBuilder<DouyinMicroAppClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<DouyinMicroAppClient> ICommonClientBuilder<DouyinMicroAppClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public DouyinMicroAppClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public DouyinMicroAppClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public DouyinMicroAppClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public DouyinMicroAppClient Build()
        {
            DouyinMicroAppClient client = _disposeClient.HasValue
                ? new DouyinMicroAppClient(_options, _httpClient, _disposeClient.Value)
                : new DouyinMicroAppClient(_options, _httpClient);

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

    partial class DouyinMicroAppClientBuilder
    {
        public static DouyinMicroAppClientBuilder Create(DouyinMicroAppClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new DouyinMicroAppClientBuilder(options);
        }
    }
}
