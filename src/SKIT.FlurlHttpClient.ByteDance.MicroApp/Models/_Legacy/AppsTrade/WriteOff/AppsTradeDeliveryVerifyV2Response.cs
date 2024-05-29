namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/delivery_verify 接口的响应。</para>
    /// </summary>
    public class AppsTradeDeliveryVerifyV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置商品单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                        public string ItemOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_code")]
                        public string CertificateCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置验券结果码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("result_code")]
                        public int ResultCode { get; set; }

                        /// <summary>
                        /// 获取或设置验券结果说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("result_msg")]
                        public string? ResultMessage { get; set; }

                        /// <summary>
                        /// 获取或设置核销时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_time")]
                        public long VerifyTimeMilliseconds { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_results")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_results")]
                public Types.Result[] ResultList { get; set; } = default!;
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
