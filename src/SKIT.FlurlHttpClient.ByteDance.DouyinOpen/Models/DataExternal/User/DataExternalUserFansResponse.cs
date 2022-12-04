namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/user/fans 接口的响应。</para>
    /// </summary>
    public class DataExternalUserFansResponse : DouyinOpenResponse<DataExternalUserFansResponse.Types.Data>
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
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置当天新粉丝数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_fans")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_fans")]
                        public int NewFansCount { get; set; }

                        /// <summary>
                        /// 获取或设置当天粉丝总数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_fans")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_fans")]
                        public int TotalFansCount { get; set; }
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
