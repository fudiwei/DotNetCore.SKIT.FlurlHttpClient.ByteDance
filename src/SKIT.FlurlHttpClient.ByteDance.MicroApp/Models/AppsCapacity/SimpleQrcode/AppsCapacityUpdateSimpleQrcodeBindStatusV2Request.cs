namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v2/capacity/update_simple_qr_bind_status/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityUpdateSimpleQrcodeBindStatusV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置链接地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_url")]
        [System.Text.Json.Serialization.JsonPropertyName("qr_url")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
