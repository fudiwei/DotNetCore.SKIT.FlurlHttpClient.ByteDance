namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/poi/base 接口的响应。</para>
    /// </summary>
    public class DataExternalPOIBaseResponse : TikTokResponse<DataExternalPOIBaseResponse.Types.Data>
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
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置详情页 UV。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail_vv")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail_vv")]
                        public int DetailUV { get; set; }
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
