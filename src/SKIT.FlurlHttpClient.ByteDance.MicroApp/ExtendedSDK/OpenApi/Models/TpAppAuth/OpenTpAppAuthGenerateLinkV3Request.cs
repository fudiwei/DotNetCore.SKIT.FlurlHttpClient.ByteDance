namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /tpapp/v3/auth/gen_link 接口的请求。</para>
    /// </summary>
    public class OpenTpAppAuthGenerateLinkV3Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置授权链接类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_type")]
        [System.Text.Json.Serialization.JsonPropertyName("link_type")]
        public int? LinkType { get; set; }

        /// <summary>
        /// 获取或设置代创建的小程序图标文件路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_icon")]
        [System.Text.Json.Serialization.JsonPropertyName("app_icon")]
        public string? AppIconPath { get; set; }

        /// <summary>
        /// 获取或设置代创建的小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name")]
        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// 获取或设置授权回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_uri")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        public string? RedirectUrl { get; set; }
    }
}
