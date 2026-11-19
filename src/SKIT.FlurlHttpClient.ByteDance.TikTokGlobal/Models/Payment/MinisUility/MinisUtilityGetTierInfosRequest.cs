namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/utility/get_tier_infos/ 接口的请求。</para>
    /// </summary>
    public class MinisUtilityGetTierInfosRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置代币类型。
        /// <para>默认值："BEANS"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token_type")]
        [System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; } = "BEANS";

        /// <summary>
        /// 获取或设置等级 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tier_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("tier_ids")]
        public List<string>? TierIdList { get; set; }
    }
}
