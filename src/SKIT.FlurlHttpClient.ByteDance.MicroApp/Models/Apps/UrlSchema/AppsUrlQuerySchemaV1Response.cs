namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/url/query_schema/ 接口的响应。</para>
    /// </summary>
    public class AppsUrlQuerySchemaV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置小程序的 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string? PagePath { get; set; }

                /// <summary>
                /// 获取或设置页面查询参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string? QueryString { get; set; }

                /// <summary>
                /// 获取或设置生成时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置失效时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long ExpireTimestamp { get; set; }
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
