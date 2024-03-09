using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_video_deal_data 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-02 下线。")]
    public class AppsDataAnalysisQueryVideoDealDataV1Response : DouyinMicroAppResponse
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
                        /// 获取或设置锚点曝光次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_show_pv")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_show_pv")]
                        public int MpShowPV { get; set; }

                        /// <summary>
                        /// 获取或设置锚点点击次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_click_pv")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_click_pv")]
                        public int MpClickPV { get; set; }

                        /// <summary>
                        /// 获取或设置创建订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_order_cnt")]
                        public int CreateOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_cnt")]
                        public int PayOrderCount { get; set; }
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
                /// 获取或设置短视频交易分析总览数据信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_deal_overview_data")]
                [System.Text.Json.Serialization.JsonPropertyName("video_deal_overview_data")]
                public Types.VideoDealOverviewData VideoDealOverviewData { get; set; } = default!;

                /// <summary>
                /// 获取或设置短视频交易分析每日数据列表。
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
