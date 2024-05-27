namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/platform/v2/data_analysis/query_small_home_overview_data/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQuerySmallHomeOverviewDataV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SmallHomeOverviewData
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                        public string AppName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置核销订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_success_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_success_order_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int DeliverySuccessOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置核销订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_success_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_success_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long DeliverySuccessAmount { get; set; }

                        /// <summary>
                        /// 获取或设置累计主播数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_anchors_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_anchors_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int LiveAnchorCount { get; set; }

                        /// <summary>
                        /// 获取或设置累计直播时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_duration")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int LiveDuration { get; set; }

                        /// <summary>
                        /// 获取或设置累计直播场次。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_session_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_session_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int LiveSessionCount { get; set; }

                        /// <summary>
                        /// 获取或设置直播最高在线人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_watch_user_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_watch_user_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int LiveHighestOnlineUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置直播累计观看人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("watch_user_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("watch_user_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int LiveWatchUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置直播累计观看时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("watch_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("watch_duration")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int LiveWatchDuration { get; set; }

                        /// <summary>
                        /// 获取或设置直播人均观看时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("per_watch_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("per_watch_duration")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int LiveOnceWatchDuration { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_success_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_success_order_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int RefundSuccessOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_success_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_success_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long RefundSuccessAmount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_name")]
                [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                public string AppName { get; set; } = default!;

                /// <summary>
                /// 获取或设置小房子直播总览数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("over_view_data")]
                [System.Text.Json.Serialization.JsonPropertyName("over_view_data")]
                public Types.SmallHomeOverviewData SmallHomeOverviewData { get; set; } = default!;
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
