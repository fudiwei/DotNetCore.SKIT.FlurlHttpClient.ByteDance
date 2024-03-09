namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /modify_qualification 接口的响应。</para>
    /// </summary>
    public class ProductModifyQualificationResponse : DouyinMicroAppProductApiResponse
    {
        public static class Types
        {
            public class Data : ProductAddQualificationResponse.Types.Data
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
