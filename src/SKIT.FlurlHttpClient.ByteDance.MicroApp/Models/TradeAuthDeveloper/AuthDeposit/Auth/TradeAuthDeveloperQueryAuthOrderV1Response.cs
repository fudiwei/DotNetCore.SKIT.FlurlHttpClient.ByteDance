namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/query_auth_order/ 接口的响应。</para>
    /// </summary>
    public class TradeAuthDeveloperQueryAuthOrderV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开发者信用单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_auth_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_auth_order_no")]
                public string OutAuthOrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置信用单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_order_id")]
                public string AuthOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置信用单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置免押场景。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene")]
                [System.Text.Json.Serialization.JsonPropertyName("scene")]
                public int Scene { get; set; }

                /// <summary>
                /// 获取或设置信用模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_id")]
                [System.Text.Json.Serialization.JsonPropertyName("service_id")]
                public string ServiceId { get; set; } = default!;

                /// <summary>
                /// 获取或设置押金金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置收款商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
                public string MerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置回调通知地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notify_url")]
                [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
                public string? NotifyUrl { get; set; }

                /// <summary>
                /// 获取或设置签约时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sign_time")]
                [System.Text.Json.Serialization.JsonPropertyName("sign_time")]
                public long? SignTimeMilliseconds { get; set; }
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
