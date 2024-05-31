namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/book/create_book 接口的响应。</para>
    /// </summary>
    public class AppsTradeBookCreateBookV2Response : DouyinOpenResponse<AppsTradeBookCreateBookV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class MarkupOrderInfo
                    {
                        /// <summary>
                        /// 获取或设置加价单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("markup_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("markup_order_id")]
                        public string MarkupOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置唤起收银台的支付订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
                        public string PayOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置唤起收银台的 Token。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_token")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_token")]
                        public string PayOrderToken { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置预约单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("book_id")]
                [System.Text.Json.Serialization.JsonPropertyName("book_id")]
                public string BookId { get; set; } = default!;

                /// <summary>
                /// 获取或设置加价单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("markup_order_info")]
                [System.Text.Json.Serialization.JsonPropertyName("markup_order_info")]
                public Types.MarkupOrderInfo? MarkupOrderInfo { get; set; }
            }
        }
    }
}
