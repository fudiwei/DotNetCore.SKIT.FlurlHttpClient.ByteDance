namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/customer_service/url 接口的响应。</para>
    /// </summary>
    public class AppsCustomerServiceUrlResponse : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置客服链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;
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
