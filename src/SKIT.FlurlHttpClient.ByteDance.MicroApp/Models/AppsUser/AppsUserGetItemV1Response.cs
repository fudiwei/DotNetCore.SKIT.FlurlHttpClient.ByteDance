namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/user/get_item/ 接口的响应。</para>
    /// </summary>
    public class AppsUserGetItemV1Response : DouyinMicroAppResponse
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
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置新增播放数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_play")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_play")]
                        public long NewPlayCount { get; set; }

                        /// <summary>
                        /// 获取或设置发布内容数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_issue")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_issue")]
                        public long NewIssueCount { get; set; }

                        /// <summary>
                        /// 获取或设置内容总数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_issue")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_issue")]
                        public long TotalIssueCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置返回结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result_list")]
                [System.Text.Json.Serialization.JsonPropertyName("result_list")]
                public Types.Result[] ResultList { get; set; } = default!;
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
