namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/taskbox/update_orient_talents/ 接口的响应。</para>
    /// </summary>
    public class AppsTaskBoxUpdateOrientTalentsResponse : AppsTaskBoxResponseBase
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
                        /// 获取或设置达人抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("douyin_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("douyin_id")]
                        public string DouyinId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置更新结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_result")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_result")]
                        public string UpdateResult { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置更新结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("update_info_list")]
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
