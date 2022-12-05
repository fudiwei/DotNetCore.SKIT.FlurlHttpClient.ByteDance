namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/user/item 接口的响应。</para>
    /// </summary>
    public class DataExternalUserItemResponse : DouyinOpenResponse<DataExternalUserItemResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置当天发布内容数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_issue")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_issue")]
                        public int NewIssueCount { get; set; }

                        /// <summary>
                        /// 获取或设置当天内容总数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_issue")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_issue")]
                        public int TotalIssueCount { get; set; }

                        /// <summary>
                        /// 获取或设置当天新增视频播放。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_play")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_play")]
                        public int NewPlayCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result_list")]
                [System.Text.Json.Serialization.JsonPropertyName("result_list")]
                public Types.Result[] ResultList { get; set; } = default!;
            }
        }
    }
}
