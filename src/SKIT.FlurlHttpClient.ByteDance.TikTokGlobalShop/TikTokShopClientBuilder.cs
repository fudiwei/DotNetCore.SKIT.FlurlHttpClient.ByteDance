using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    /// <summary>
    /// 用于构造 <see cref="TikTokShopClient"/> 实例的构造器。
    /// </summary>
    public partial class TikTokShopClientBuilder : ICommonClientBuilder<TikTokShopClient>
    {
        private readonly TikTokShopClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private TikTokShopClientBuilder(TikTokShopClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<TikTokShopClient> ICommonClientBuilder<TikTokShopClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<TikTokShopClient> ICommonClientBuilder<TikTokShopClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<TikTokShopClient> ICommonClientBuilder<TikTokShopClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public TikTokShopClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public TikTokShopClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public TikTokShopClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public TikTokShopClient Build()
        {
            TikTokShopClient client = _disposeClient.HasValue
                ? new TikTokShopClient(_options, _httpClient, _disposeClient.Value)
                : new TikTokShopClient(_options, _httpClient);

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

    partial class TikTokShopClientBuilder
    {
        public static TikTokShopClientBuilder Create(TikTokShopClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new TikTokShopClientBuilder(options);
        }
    }
}
