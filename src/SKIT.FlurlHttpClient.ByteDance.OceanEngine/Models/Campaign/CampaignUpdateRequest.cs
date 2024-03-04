namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/campaign/update 接口的请求。</para>
    /// </summary>
    public class CampaignUpdateRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置广告组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_id")]
        [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
        public long CampaignId { get; set; }

        /// <summary>
        /// 获取或设置广告组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_name")]
        [System.Text.Json.Serialization.JsonPropertyName("campaign_name")]
        public string? CampaignName { get; set; }

        /// <summary>
        /// 获取或设置广告组预算（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budget")]
        [System.Text.Json.Serialization.JsonPropertyName("budget")]
        public decimal? Budget { get; set; }

        /// <summary>
        /// 获取或设置广告组预算类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budget_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("budget_mode")]
        public string? BudgetMode { get; set; }

        /// <summary>
        /// 获取或设置修改时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_time")]
        [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
        public long ModifyTimestamp { get; set; }
    }
}
