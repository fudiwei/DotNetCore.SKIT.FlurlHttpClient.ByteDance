namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_resource_status 接口的响应。</para>
    /// </summary>
    public class ProductApiQueryResourceStatusResponse : ByteDanceMicroAppProductApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置资源路径
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_uri")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_uri")]
                public string ResourcePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置上传状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
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
