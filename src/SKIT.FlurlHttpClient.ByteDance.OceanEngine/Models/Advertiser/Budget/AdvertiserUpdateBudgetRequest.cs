namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/advertiser/update/budget 接口的请求。</para>
    /// </summary>
    public class AdvertiserUpdateBudgetRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置预算（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budget")]
        [System.Text.Json.Serialization.JsonPropertyName("budget")]
        public double? Budget { get; set; }

        /// <summary>
        /// 获取或设置预算类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budget_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("budget_mode")]
        public string BudgetMode { get; set; } = string.Empty;
    }
}
