namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v2/basic_info/get_qr_code 接口的请求。</para>
    /// </summary>
    public class OpenAppsBasicInfoGetQrcodeV2Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置版本。
        /// <para>默认值："current"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version")]
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string Version { get; set; } = "current";

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string PagePath { get; set; } = string.Empty;
    }
}
