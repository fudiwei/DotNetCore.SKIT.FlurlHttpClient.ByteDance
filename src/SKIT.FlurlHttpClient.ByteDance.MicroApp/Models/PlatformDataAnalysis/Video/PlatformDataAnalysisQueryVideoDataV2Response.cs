namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_video_data/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryVideoDataV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class VideoDealOverviewData
                    {
                        /// <summary>
                        /// 获取或设置视频播放次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_play_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_play_cnt")]
                        public int VideoPlayCount { get; set; }

                        /// <summary>
                        /// 获取或设置视频播放人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_play_user_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_play_user_cnt")]
                        public int VideoPlayUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置小程序曝光次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_show_pv")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_show_pv")]
                        public int MicroAppShowPV { get; set; }

                        /// <summary>
                        /// 获取或设置小程序曝光人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_show_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_show_uv")]
                        public int MicroAppShowUV { get; set; }

                        /// <summary>
                        /// 获取或设置小程序点击次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_click_pv")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_click_pv")]
                        public int MicroAppClickPV { get; set; }

                        /// <summary>
                        /// 获取或设置小程序点击人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_click_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_click_uv")]
                        public int MicroAppClickUV { get; set; }

                        /// <summary>
                        /// 获取或设置进入小程序次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_drainage_pv")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_drainage_pv")]
                        public int MicroAppDrainagePV { get; set; }

                        /// <summary>
                        /// 获取或设置进入小程序人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_drainage_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_drainage_uv")]
                        public int MicroAppDrainageUV { get; set; }

                        /// <summary>
                        /// 获取或设置线索数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("clue_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("clue_cnt")]
                        public int ClueCount { get; set; }

                        /// <summary>
                        /// 获取或设置有效线索数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_clue_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_clue_cnt")]
                        public int ValidClueCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_order_cnt")]
                        public int CreateOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建订单人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_customer_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_customer_cnt")]
                        public int CreateUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_order_amount")]
                        public long CreateOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_cnt")]
                        public int PayOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_customer_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_customer_cnt")]
                        public int PayUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_amount")]
                        public long PayOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_order_cnt")]
                        public int RefundOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_customer_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_customer_cnt")]
                        public int RefundUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                        public long RefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置客单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_once_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_once_price")]
                        public long CustomerOncePrice { get; set; }

                        /// <summary>
                        /// 获取或设置单均价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_once_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_once_price")]
                        public long OrderOncePrice { get; set; }
                    }

                    public class VideoDealData : VideoDealOverviewData
                    {
                        /// <summary>
                        /// 获取或设置时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time")]
                        [System.Text.Json.Serialization.JsonPropertyName("time")]
                        public string TimeString { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置短视频总览数据信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_deal_overview_data")]
                [System.Text.Json.Serialization.JsonPropertyName("video_deal_overview_data")]
                public Types.VideoDealOverviewData VideoDealOverviewData { get; set; } = default!;

                /// <summary>
                /// 获取或设置短视频每日数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_deal_data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("video_deal_data_list")]
                public Types.VideoDealData[] VideoDealDataList { get; set; } = default!;
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
