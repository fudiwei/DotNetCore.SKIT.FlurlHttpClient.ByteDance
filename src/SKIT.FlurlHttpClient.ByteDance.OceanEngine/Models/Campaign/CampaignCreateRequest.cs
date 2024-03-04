namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/campaign/create 接口的请求。</para>
    /// </summary>
    public class CampaignCreateRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置广告组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_name")]
        [System.Text.Json.Serialization.JsonPropertyName("campaign_name")]
        public string CampaignName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告组类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_type")]
        [System.Text.Json.Serialization.JsonPropertyName("campaign_type")]
        public string? CampaignType { get; set; }

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
        public string BudgetMode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告组推广目的。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("landing_type")]
        [System.Text.Json.Serialization.JsonPropertyName("landing_type")]
        public string LandingType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告组营销目的。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marketing_purpose")]
        [System.Text.Json.Serialization.JsonPropertyName("marketing_purpose")]
        public string? MarketingPurpose { get; set; }

        /// <summary>
        /// 获取或设置操作状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operation")]
        [System.Text.Json.Serialization.JsonPropertyName("operation")]
        public string? Operation { get; set; }

        /// <summary>
        /// 获取或设置商品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_related_num")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_related_num")]
        public string? DeliveryRelatedType { get; set; }

        /// <summary>
        /// 获取或设置投放类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_mode")]
        public string? DeliveryMode { get; set; }
    }
}
