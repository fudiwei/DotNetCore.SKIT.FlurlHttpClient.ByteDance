using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    /// <summary>
    /// 用于构造 <see cref="TikTokV2Client"/> 实例的构造器。
    /// </summary>
    public partial class TikTokV2ClientBuilder : ICommonClientBuilder<TikTokV2Client>
    {
        private readonly TikTokV2ClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private TikTokV2ClientBuilder(TikTokV2ClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<TikTokV2Client> ICommonClientBuilder<TikTokV2Client>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<TikTokV2Client> ICommonClientBuilder<TikTokV2Client>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<TikTokV2Client> ICommonClientBuilder<TikTokV2Client>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public TikTokV2ClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public TikTokV2ClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public TikTokV2ClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public TikTokV2Client Build()
        {
            TikTokV2Client client = _disposeClient.HasValue
                ? new TikTokV2Client(_options, _httpClient, _disposeClient.Value)
                : new TikTokV2Client(_options, _httpClient);

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

    partial class TikTokV2ClientBuilder
    {
        public static TikTokV2ClientBuilder Create(TikTokV2ClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new TikTokV2ClientBuilder(options);
        }
    }
}
