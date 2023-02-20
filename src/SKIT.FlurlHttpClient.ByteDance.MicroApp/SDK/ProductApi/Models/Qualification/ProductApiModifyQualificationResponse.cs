namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /modify_qualification 接口的响应。</para>
    /// </summary>
    public class ProductApiModifyQualificationResponse : ByteDanceMicroAppProductApiResponse
    {
        public static class Types
        {
            public class Data : ProductApiAddQualificationResponse.Types.Data
            {
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
