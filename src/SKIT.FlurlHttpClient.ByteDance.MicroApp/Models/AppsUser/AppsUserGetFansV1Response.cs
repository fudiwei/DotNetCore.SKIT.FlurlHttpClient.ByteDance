namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/user/get_fans/ 接口的响应。</para>
    /// </summary>
    public class AppsUserGetFansV1Response : DouyinMicroAppResponse
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
                        /// 获取或设置新增粉丝数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_fans")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_fans")]
                        public long NewFansCount { get; set; }

                        /// <summary>
                        /// 获取或设置总粉丝数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_fans")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_fans")]
                        public long TotalFansCount { get; set; }
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
