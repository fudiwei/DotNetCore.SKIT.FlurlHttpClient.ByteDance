namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    /// <summary>
    /// 字节小程序服务商平台 API 请求的基类。
    /// </summary>
    public abstract class ByteDanceMicroAppOpenApiRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置字节小程序第三方 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppOpenApiClient"/> 时的 <see cref="ByteDanceMicroAppOpenApiClientOptions.ComponentAppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置字节小程序第三方的 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? ComponentAccessToken { get; set; }

        /// <summary>
        /// 获取或设置字节小程序授权方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AuthorizerAppId { get; set; }

        /// <summary>
        /// 获取或设置字节小程序授权方的 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AuthorizerAccessToken { get; set; }
    }
}
