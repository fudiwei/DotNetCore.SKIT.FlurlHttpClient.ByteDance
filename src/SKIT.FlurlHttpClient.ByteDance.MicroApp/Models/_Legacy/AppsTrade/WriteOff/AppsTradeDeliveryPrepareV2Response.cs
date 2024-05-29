namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/delivery_prepare 接口的响应。</para>
    /// </summary>
    public class AppsTradeDeliveryPrepareV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Certificate
                    {
                        /// <summary>
                        /// 获取或设置加密券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("encrypted_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("encrypted_code")]
                        public string EncryptedCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                        public string CertificateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                        public string ItemOrderId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置开发者订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
                public string OutOrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置验券 Token。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_token")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_token")]
                public string VerifyToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置可用券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificates")]
                [System.Text.Json.Serialization.JsonPropertyName("certificates")]
                public Types.Certificate[] CertificateList { get; set; } = default!;
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
