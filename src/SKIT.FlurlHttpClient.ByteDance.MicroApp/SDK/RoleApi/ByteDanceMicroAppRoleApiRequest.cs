namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi
{
    /// <summary>
    /// 字节小程序泛知识角色系统 API 请求的基类。
    /// </summary>
    public class ByteDanceMicroAppRoleApiRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="ByteDanceMicroAppRoleApiClient"/> 时的 <see cref="ByteDanceMicroAppRoleApiClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

        /// <summary>
        /// 获取或设置字节小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppRoleApiClient"/> 时的 <see cref="ByteDanceMicroAppRoleApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public virtual string? AppId { get; set; }

        /// <summary>
        /// 获取或设置字节小程序的 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public virtual string? AccessToken { get; set; }
    }
}
