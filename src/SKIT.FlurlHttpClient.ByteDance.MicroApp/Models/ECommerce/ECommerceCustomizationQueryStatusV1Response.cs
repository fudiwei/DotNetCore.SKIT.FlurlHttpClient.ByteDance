namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/ecom/v1/customization/query_status/ 接口的响应。</para>
    /// </summary>
    public class ECommerceCustomizationQueryStatusV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置定制状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_code")]
                [System.Text.Json.Serialization.JsonPropertyName("success_code")]
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
