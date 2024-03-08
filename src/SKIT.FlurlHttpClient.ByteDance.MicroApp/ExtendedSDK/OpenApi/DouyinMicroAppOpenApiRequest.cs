namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    /// <summary>
    /// 抖音小程序服务商平台 API 请求的基类。
    /// </summary>
    public abstract class DouyinMicroAppOpenApiRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置抖音小程序第三方 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppOpenApiClient"/> 时的 <see cref="DouyinMicroAppOpenApiClientOptions.ComponentAppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置抖音小程序第三方的 AccessToken。
        /// <para>注意：v1、v2 版的 ComponentAccessToken 不可混用。</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? ComponentAccessToken { get; set; }

        /// <summary>
        /// 获取或设置抖音小程序授权方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AuthorizerAppId { get; set; }

        /// <summary>
        /// 获取或设置抖音小程序授权方的 AccessToken。
        /// <para>注意：v1、v2 版的 AuthorizerAccessToken 不可混用。</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AuthorizerAccessToken { get; set; }
    }
}
