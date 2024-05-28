namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/create_auth_order/ 接口的响应。</para>
    /// </summary>
    public class TradeAuthDeveloperCreateAuthOrderV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置信用单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_order_id")]
                public string AuthOrderId { get; set; } = default!;
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
