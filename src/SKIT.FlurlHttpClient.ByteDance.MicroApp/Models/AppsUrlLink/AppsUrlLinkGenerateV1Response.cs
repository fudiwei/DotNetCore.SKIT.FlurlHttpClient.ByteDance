namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/url_link/generate 接口的响应。</para>
    /// </summary>
    public class AppsUrlLinkGenerateV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url_link")]
                [System.Text.Json.Serialization.JsonPropertyName("url_link")]
                public string UrlLink { get; set; } = default!;
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
