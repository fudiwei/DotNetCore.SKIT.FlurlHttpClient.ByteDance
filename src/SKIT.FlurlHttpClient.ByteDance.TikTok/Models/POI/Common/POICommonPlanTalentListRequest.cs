namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/talent/list 接口的请求。</para>
    /// </summary>
    public class POICommonPlanTalentListRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置通用佣金计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_no")]
        [System.Text.Json.Serialization.JsonPropertyName("page_no")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;
    }
}
