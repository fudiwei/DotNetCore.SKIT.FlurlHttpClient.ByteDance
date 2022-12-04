namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/fans/source 接口的响应。</para>
    /// </summary>
    public class DataExternalFansSourceResponse : DouyinOpenResponse<DataExternalFansSourceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source")]
                        [System.Text.Json.Serialization.JsonPropertyName("source")]
                        public string Source { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置占比字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("percent")]
                        [System.Text.Json.Serialization.JsonPropertyName("percent")]
                        public string PercentString { get; set; } = default!;
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
