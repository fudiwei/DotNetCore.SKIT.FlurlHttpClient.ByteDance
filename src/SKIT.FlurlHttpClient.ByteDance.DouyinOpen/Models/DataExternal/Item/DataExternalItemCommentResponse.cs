namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/item/comment 接口的响应。</para>
    /// </summary>
    public class DataExternalItemCommentResponse : DouyinOpenResponse<DataExternalItemCommentResponse.Types.Data>
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
                        /// 获取或设置当天新评论数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment")]
                        public int NewCommentCount { get; set; }
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
