namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/orienPlanAuthors 接口的请求。</para>
    /// </summary>
    public class BuyinOrientPlanAuthorsRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置定向计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orien_plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("orien_plan_id")]
        public string OrientPlanId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置达人百应 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyin_id")]
        [System.Text.Json.Serialization.JsonPropertyName("buyin_id")]
        public int? BuyinId { get; set; }

        /// <summary>
        /// 获取或设置达人昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        public string? AuthorName { get; set; }

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_status")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
        public int? AuditStatus { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// <para>默认值：20</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 20;
    }
}
