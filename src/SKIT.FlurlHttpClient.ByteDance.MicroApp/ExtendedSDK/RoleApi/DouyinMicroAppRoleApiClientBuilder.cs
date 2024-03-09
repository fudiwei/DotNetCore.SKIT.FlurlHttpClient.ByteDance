using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi
{
    /// <summary>
    /// 用于构造 <see cref="DouyinMicroAppRoleApiClient"/> 实例的构造器。
    /// </summary>
    public partial class DouyinMicroAppRoleApiClientBuilder : ICommonClientBuilder<DouyinMicroAppRoleApiClient>
    {
        private readonly DouyinMicroAppRoleApiClientOptions _options;
        private readonly IList<Action<CommonClientSettings>> _configures;
        private readonly IList<HttpInterceptor> _interceptors;
        private HttpClient? _httpClient;
        private bool? _disposeClient;

        private DouyinMicroAppRoleApiClientBuilder(DouyinMicroAppRoleApiClientOptions options)
        {
            _options = options;
            _configures = new List<Action<CommonClientSettings>>();
            _interceptors = new List<HttpInterceptor>();
        }

        ICommonClientBuilder<DouyinMicroAppRoleApiClient> ICommonClientBuilder<DouyinMicroAppRoleApiClient>.ConfigureSettings(Action<CommonClientSettings> configure)
        {
            return ConfigureSettings(configure);
        }

        ICommonClientBuilder<DouyinMicroAppRoleApiClient> ICommonClientBuilder<DouyinMicroAppRoleApiClient>.UseInterceptor(HttpInterceptor interceptor)
        {
            return UseInterceptor(interceptor);
        }

        ICommonClientBuilder<DouyinMicroAppRoleApiClient> ICommonClientBuilder<DouyinMicroAppRoleApiClient>.UseHttpClient(HttpClient httpClient, bool disposeClient)
        {
            return UseHttpClient(httpClient, disposeClient);
        }

        public DouyinMicroAppRoleApiClientBuilder ConfigureSettings(Action<CommonClientSettings> configure)
        {
            if (configure is null) throw new ArgumentNullException(nameof(configure));

            _configures.Add(configure);
            return this;
        }

        public DouyinMicroAppRoleApiClientBuilder UseInterceptor(HttpInterceptor interceptor)
        {
            if (interceptor is null) throw new ArgumentNullException(nameof(interceptor));

            _interceptors.Add(interceptor);
            return this;
        }

        public DouyinMicroAppRoleApiClientBuilder UseHttpClient(HttpClient httpClient, bool disposeClient = true)
        {
            if (httpClient is null) throw new ArgumentNullException(nameof(httpClient));

            _httpClient = httpClient;
            _disposeClient = disposeClient;
            return this;
        }

        public DouyinMicroAppRoleApiClient Build()
        {
            DouyinMicroAppRoleApiClient client = _disposeClient.HasValue
                ? new DouyinMicroAppRoleApiClient(_options, _httpClient, _disposeClient.Value)
                : new DouyinMicroAppRoleApiClient(_options, _httpClient);

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

    partial class DouyinMicroAppRoleApiClientBuilder
    {
        public static DouyinMicroAppRoleApiClientBuilder Create(DouyinMicroAppRoleApiClientOptions options)
        {
            if (options is null) throw new ArgumentNullException(nameof(options));

            return new DouyinMicroAppRoleApiClientBuilder(options);
        }
    }
}
