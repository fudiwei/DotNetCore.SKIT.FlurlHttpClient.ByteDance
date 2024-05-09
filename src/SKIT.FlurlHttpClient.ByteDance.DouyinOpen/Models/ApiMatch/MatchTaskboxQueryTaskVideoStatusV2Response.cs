namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v2/taskbox/query_task_video_status/ 接口的响应。</para>
    /// </summary>
    public class MatchTaskboxQueryTaskVideoStatusV2Response : DouyinOpenResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long VideoId { get; set; }

                        /// <summary>
                        /// 获取或设置视频状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_status")]
                        public int VideoStatus { get; set; }

                        /// <summary>
                        /// 获取或设置短视频锚点解绑原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unbind_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("unbind_reason")]
                        public string? UnbindReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("results")]
                [System.Text.Json.Serialization.JsonPropertyName("results")]
                public Types.Result[] ResultList { get; set; } = default!;
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
        public Types.Data Data { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0;
        }
    }
}
