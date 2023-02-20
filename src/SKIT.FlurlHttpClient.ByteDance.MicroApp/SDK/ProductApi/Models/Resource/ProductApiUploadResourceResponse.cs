namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /upload_resource 接口的响应。</para>
    /// </summary>
    public class ProductApiUploadResourceResponse : ByteDanceMicroAppProductApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置资源路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_uri")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_uri")]
                public string ResourcePath { get; set; } = default!;
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
