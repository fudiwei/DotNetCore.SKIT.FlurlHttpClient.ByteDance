namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/save 接口的请求。</para>
    /// </summary>
    public class POICommonPlanSaveRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_id")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
        public long SPUId { get; set; }

        /// <summary>
        /// 获取或设置计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public long? PlanId { get; set; }

        /// <summary>
        /// 获取或设置达人带货场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_type")]
        [System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public int ContentType { get; set; }

        /// <summary>
        /// 获取或设置达人佣金率。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commission_rate")]
        [System.Text.Json.Serialization.JsonPropertyName("commission_rate")]
        public int CommissionRate { get; set; }
    }
}
