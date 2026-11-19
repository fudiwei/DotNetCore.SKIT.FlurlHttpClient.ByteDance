namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/subscription/get_subscription_tier_info/ 接口的请求。</para>
    /// </summary>
    public class MinisSubscriptionGetSubscriptionTierInfoRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置等级 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tier_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("tier_ids")]
        public List<string>? TierIdList { get; set; }

        /// <summary>
        /// 获取或设置设备平台类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_platform")]
        [System.Text.Json.Serialization.JsonPropertyName("device_platform")]
        public string? DevicePlatform { get; set; }
    }
}
