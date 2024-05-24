namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/capacity/query_aweme_video_keyword_list/ 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryAwemeVideoKeywordListV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Keyword
                    {
                        /// <summary>
                        /// 获取或设置关键词 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("keyword_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("keyword_id")]
                        public string KeywordId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置关键词字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("keyword")]
                        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
                        public string KeywordString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason_list")]
                        public string[]? RejectReasonList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置关键词列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword_list")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
                public Types.Keyword[] KeywordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }
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
