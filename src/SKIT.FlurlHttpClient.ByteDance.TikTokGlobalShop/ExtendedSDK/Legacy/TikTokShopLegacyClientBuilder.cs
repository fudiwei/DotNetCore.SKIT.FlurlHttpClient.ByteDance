using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy
{
    /// <summary>
    /// 用于构造 <see cref="TikTokShopLegacyClient"/> 实例的构造器。
    /// </summary>
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public partial class TikTokShopLegacyClientBuilder : ICommonClientBuilder<TikTokShopLegacyClient>
    {
        private readonly TikTokShopLegacyClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private TikTokShopLegacyClientBuilder(TikTokShopLegacyClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<TikTokShopLegacyClient> ICommonClientBuilder<TikTokShopLegacyClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<TikTokShopLegacyClient> ICommonClientBuilder<TikTokShopLegacyClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<TikTokShopLegacyClient> ICommonClientBuilder<TikTokShopLegacyClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public TikTokShopLegacyClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public TikTokShopLegacyClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public TikTokShopLegacyClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public TikTokShopLegacyClient Build()
        {
            TikTokShopLegacyClient client = _disposeClient.HasValue
                ? new TikTokShopLegacyClient(_options, _httpClient, _disposeClient.Value)
                : new TikTokShopLegacyClient(_options, _httpClient);

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

    partial class TikTokShopLegacyClientBuilder
    {
        public static TikTokShopLegacyClientBuilder Create(TikTokShopLegacyClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new TikTokShopLegacyClientBuilder(options);
        }
    }
}
