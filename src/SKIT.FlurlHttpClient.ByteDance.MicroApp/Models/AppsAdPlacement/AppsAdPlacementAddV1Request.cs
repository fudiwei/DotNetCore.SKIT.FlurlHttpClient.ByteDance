namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/ad_placement/add/ 接口的请求。</para>
    /// </summary>
    public class AppsAdPlacementAddV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置广告位名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_placement_name")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_placement_name")]
        public string AdPlacementName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告位类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_placement_type")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_placement_type")]
        public int AdPlacementType { get; set; }
    }
}
