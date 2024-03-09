namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi
{
    /// <summary>
    /// 抖音小程序泛知识角色系统 API 请求的基类。
    /// </summary>
    public class DouyinMicroAppRoleApiRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置抖音小程序的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppRoleApiClient"/> 时的 <see cref="DouyinMicroAppRoleApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public virtual string? AppId { get; set; }

        /// <summary>
        /// 获取或设置抖音小程序的 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public virtual string? AccessToken { get; set; }
    }
}
