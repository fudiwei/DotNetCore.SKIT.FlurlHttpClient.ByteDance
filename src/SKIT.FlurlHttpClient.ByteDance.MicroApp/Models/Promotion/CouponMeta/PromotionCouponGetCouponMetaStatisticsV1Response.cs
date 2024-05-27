namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/get_coupon_meta_statistics 接口的响应。</para>
    /// </summary>
    public class PromotionCouponGetCouponMetaStatisticsV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ActivityData
                    {
                        /// <summary>
                        /// 获取或设置活动 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                        public string ActivityId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置领取数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consumed_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("consumed_num")]
                        public long ConsumedNumber { get; set; }

                        /// <summary>
                        /// 获取或设置核销数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("received_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("received_num")]
                        public long ReceivedNumber { get; set; }
                    }

                    public class TalentData
                    {
                        /// <summary>
                        /// 获取或设置主播的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("talent_open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("talent_open_id")]
                        public string TalentOpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主播抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("talent_account")]
                        [System.Text.Json.Serialization.JsonPropertyName("talent_account")]
                        public string TalentAccount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置曝光数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exposed_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("exposed_num")]
                        public long ExposedNumber { get; set; }

                        /// <summary>
                        /// 获取或设置领取数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consumed_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("consumed_num")]
                        public long ConsumedNumber { get; set; }

                        /// <summary>
                        /// 获取或设置核销数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("received_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("received_num")]
                        public long ReceivedNumber { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置活动发券统计数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_stats")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_stats")]
                public Types.ActivityData[] ActivityDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置主播发券统计数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("talent_stats")]
                [System.Text.Json.Serialization.JsonPropertyName("talent_stats")]
                public Types.TalentData[] TalentDataList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
