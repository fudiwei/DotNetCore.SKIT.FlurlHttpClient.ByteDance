namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/{version}/activities/search 接口的请求。</para>
    /// </summary>
    public class PromotionSearchActivitiesRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置活动标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_title")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_title")]
        public string? ActivityTitle { get; set; }

        /// <summary>
        /// 获取或设置活动状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? ActivityStatus { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置分页令牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_token")]
        [System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? PageToken { get; set; }
    }
}
