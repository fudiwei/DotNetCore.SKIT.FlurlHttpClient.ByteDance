namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/create_sign_refund/ 接口的响应。</para>
    /// </summary>
    public class TradeAuthDeveloperCreateSignRefundV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置退款单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_refund_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_refund_id")]
                public string PayRefundId { get; set; } = default!;
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
