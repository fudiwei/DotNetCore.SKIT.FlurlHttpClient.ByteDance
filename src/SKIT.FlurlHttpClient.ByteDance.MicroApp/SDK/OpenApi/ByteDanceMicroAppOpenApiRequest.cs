namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi
{
    /// <summary>
    /// 字节小程序服务商平台 API 请求的基类。
    /// </summary>
    public abstract class ByteDanceMicroAppOpenApiRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="ByteDanceMicroAppOpenApiClient"/> 时的 <see cref="ByteDanceMicroAppOpenApiClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

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
