namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/subscription/get_subscription_tier_info/ 接口的响应。</para>
    /// </summary>
    public class MinisSubscriptionGetSubscriptionTierInfoResponse : TikTokV2Response<MinisSubscriptionGetSubscriptionTierInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SubscriptionTierInfo
                    {
                        /// <summary>
                        /// 获取或设置等级 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tier_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tier_id")]
                        public string? TierId { get; set; }

                        /// <summary>
                        /// 获取或设置扣费周期。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deduct_cycle")]
                        [System.Text.Json.Serialization.JsonPropertyName("deduct_cycle")]
                        public string? DeductCycle { get; set; }

                        /// <summary>
                        /// 获取或设置扣费类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deduct_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("deduct_type")]
                        public string? DeductType { get; set; }

                        /// <summary>
                        /// 获取或设置价格。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public string? Price { get; set; }

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string? Currency { get; set; }

                        /// <summary>
                        /// 获取或设置币种符号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("symbol")]
                        [System.Text.Json.Serialization.JsonPropertyName("symbol")]
                        public string? Symbol { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订阅等级信息字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscription_tiers_info")]
                [System.Text.Json.Serialization.JsonPropertyName("subscription_tiers_info")]
                public Dictionary<string, Types.SubscriptionTierInfo>? SubscriptionTierInfoMap { get; set; }
            }
        }
    }
}
