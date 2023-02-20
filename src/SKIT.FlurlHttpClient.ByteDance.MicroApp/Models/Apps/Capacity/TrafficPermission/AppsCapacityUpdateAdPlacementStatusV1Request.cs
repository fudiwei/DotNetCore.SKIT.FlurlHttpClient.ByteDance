namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/update_ad_placement_status 接口的请求。</para>
    /// </summary>
    public class AppsCapacityUpdateAdPlacementStatusV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置广告位 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_placement_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_placement_id")]
        public string AdPlacementId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告位状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
