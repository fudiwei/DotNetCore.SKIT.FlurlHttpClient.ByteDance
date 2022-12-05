namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/item/play 接口的响应。</para>
    /// </summary>
    public class DataExternalItemPlayResponse : DouyinOpenResponse<DataExternalItemPlayResponse.Types.Data>
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
                        /// 获取或设置当天新播放数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("play")]
                        [System.Text.Json.Serialization.JsonPropertyName("play")]
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
