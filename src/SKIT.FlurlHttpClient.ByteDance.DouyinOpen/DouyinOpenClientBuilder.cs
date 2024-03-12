using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    /// <summary>
    /// 用于构造 <see cref="DouyinOpenClient"/> 实例的构造器。
    /// </summary>
    public partial class DouyinOpenClientBuilder : ICommonClientBuilder<DouyinOpenClient>
    {
        private readonly DouyinOpenClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private DouyinOpenClientBuilder(DouyinOpenClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<DouyinOpenClient> ICommonClientBuilder<DouyinOpenClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<DouyinOpenClient> ICommonClientBuilder<DouyinOpenClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<DouyinOpenClient> ICommonClientBuilder<DouyinOpenClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public DouyinOpenClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public DouyinOpenClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public DouyinOpenClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public DouyinOpenClient Build()
        {
            DouyinOpenClient client = _disposeClient.HasValue
                ? new DouyinOpenClient(_options, _httpClient, _disposeClient.Value)
                : new DouyinOpenClient(_options, _httpClient);

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

    partial class DouyinOpenClientBuilder
    {
        public static DouyinOpenClientBuilder Create(DouyinOpenClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new DouyinOpenClientBuilder(options);
        }
    }
}
