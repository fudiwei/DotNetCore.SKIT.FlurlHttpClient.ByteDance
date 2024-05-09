namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v2/taskbox/agency_query_video_sum_data/ 接口的响应。</para>
    /// </summary>
    public class MatchTaskboxAgencyQueryVideoSummaryDataV2Response : DouyinOpenResponse
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
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long VideoId { get; set; }

                /// <summary>
                /// 获取或设置团长 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agent_id")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public long? AgentId { get; set; }

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

        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int ErrorNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string? LogId { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data[] Data { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0;
        }
    }
}
