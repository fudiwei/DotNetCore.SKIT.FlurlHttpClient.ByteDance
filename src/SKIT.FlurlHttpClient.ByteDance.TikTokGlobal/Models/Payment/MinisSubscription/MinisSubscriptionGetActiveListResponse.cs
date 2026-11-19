namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/subscription/get_active_list/ 接口的响应。</para>
    /// </summary>
    public class MinisSubscriptionGetActiveListResponse : TikTokV2Response<MinisSubscriptionGetActiveListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Subscription
                    {
                        /// <summary>
                        /// 获取或设置订阅 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subscription_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("subscription_id")]
                        public string? SubscriptionId { get; set; }

                        /// <summary>
                        /// 获取或设置等级 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tier_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tier_id")]
                        public string? TierId { get; set; }

                        /// <summary>
                        /// 获取或设置是否订阅权益有效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_subscription_rights_valid")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_subscription_rights_valid")]
                        public bool IsSubscriptionRightsValid { get; set; }

                        /// <summary>
                        /// 获取或设置是否自动续期。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_renewal_normal")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_renewal_normal")]
                        public bool IsRenewalNormal { get; set; }

                        /// <summary>
                        /// 获取或设置交易订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trade_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("trade_order_id")]
                        public string? TradeOrderId { get; set; }

                        /// <summary>
                        /// 获取或设置开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                        public long BeginTimestampMilli { get; set; }

                        /// <summary>
                        /// 获取或设置结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestampMilli { get; set; }

                        /// <summary>
                        /// 获取或设置下次扣费时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("next_deduct_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("next_deduct_time")]
                        public long NextDeductTimestampMilli { get; set; }

                        /// <summary>
                        /// 获取或设置支付方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
                        public string? PayType { get; set; }

                        /// <summary>
                        /// 获取或设置是否是沙箱环境。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_sandbox")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_sandbox")]
                        public bool? IsSandbox { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订阅列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscriptions")]
                [System.Text.Json.Serialization.JsonPropertyName("subscriptions")]
                public List<Types.Subscription>? SubscriptionList { get; set; }
            }
        }
    }
}
