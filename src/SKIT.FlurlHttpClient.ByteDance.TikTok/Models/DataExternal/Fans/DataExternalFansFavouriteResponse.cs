namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/fans/favourite 接口的响应。</para>
    /// </summary>
    public class DataExternalFansFavouriteResponse : TikTokResponse<DataExternalFansFavouriteResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置排名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rank")]
                        [System.Text.Json.Serialization.JsonPropertyName("rank")]
                        public int Rank { get; set; }

                        /// <summary>
                        /// 获取或设置关键词。
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
