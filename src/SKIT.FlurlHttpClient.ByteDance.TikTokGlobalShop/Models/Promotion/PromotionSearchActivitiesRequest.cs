namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/activity/list 接口的请求。</para>
    /// </summary>
    public class PromotionSearchActivitiesRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置活动标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置促销状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_number")]
        [System.Text.Json.Serialization.JsonPropertyName("page_number")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;
    }
}
