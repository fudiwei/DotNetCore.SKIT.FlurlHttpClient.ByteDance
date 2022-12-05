namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/fans/comment 接口的响应。</para>
    /// </summary>
    public class DataExternalFansCommentResponse : DouyinOpenResponse<DataExternalFansCommentResponse.Types.Data>
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
                        /// 获取或设置评论热词。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("keyword")]
                        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
                        public string Keyword { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置热度指数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hot_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("hot_value")]
                        public double HotValue { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Result[] ResultList { get; set; } = default!;
            }
        }
    }
}
