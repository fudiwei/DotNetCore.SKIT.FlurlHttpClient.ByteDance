namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v2/taskbox/query_video_sum_data/ 接口的响应。</para>
    /// </summary>
    public class MatchTaskBoxQueryVideoSummaryDataV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long TaskId { get; set; }

                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_id")]
                [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string VideoId { get; set; } = default!;

                /// <summary>
                /// 获取或设置团长 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
                public string? AgentId { get; set; }

                /// <summary>
                /// 获取或设置发布时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_time")]
                public long PublishTimestamp { get; set; }

                /// <summary>
                /// 获取或设置任务关联的交易金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("billing_gmv_td")]
                [System.Text.Json.Serialization.JsonPropertyName("billing_gmv_td")]
                public long BillingGMV { get; set; }

                /// <summary>
                /// 获取或设置任务关联的交易金额累计退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biling_refund_gmv_td")]
                [System.Text.Json.Serialization.JsonPropertyName("biling_refund_gmv_td")]
                public long BillingRefundGMV { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data[] Data { get; set; } = default!;
    }
}
