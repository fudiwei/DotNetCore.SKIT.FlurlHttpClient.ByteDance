namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v2/capacity/delete_simple_qr_bind/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityDeleteSimpleQrcodeBindV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置链接地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_url")]
        [System.Text.Json.Serialization.JsonPropertyName("qr_url")]
        public string Url { get; set; } = string.Empty;
    }
}
