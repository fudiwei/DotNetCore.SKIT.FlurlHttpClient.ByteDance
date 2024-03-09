namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/url/generate_schema/ 接口的响应。</para>
    /// </summary>
    public class AppsUrlGenerateSchemaV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("schema")]
                [System.Text.Json.Serialization.JsonPropertyName("schema")]
                public string UrlSchema { get; set; } = default!;
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
