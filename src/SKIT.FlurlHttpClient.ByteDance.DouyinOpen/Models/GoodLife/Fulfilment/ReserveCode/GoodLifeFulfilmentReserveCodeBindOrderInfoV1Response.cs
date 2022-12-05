namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/fulfilment/reserve_code/bind_order_info 接口的响应。</para>
    /// </summary>
    public class GoodLifeFulfilmentReserveCodeBindOrderInfoV1Response : DouyinOpenResponse<GoodLifeFulfilmentReserveCodeBindOrderInfoV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Order
                    {
                        public static class Types
                        {
                            public class Amount
                            {
                                /// <summary>
                                /// 获取或设置券原始金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_amount")]
                                public int OriginalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置用户实付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                                public int PayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商家营销金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_ticket_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_ticket_amount")]
                                public int MerchantTicketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台营销金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_ticket_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_ticket_amount")]
                                public int PlatformTicketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置支付优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("payment_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("payment_discount_amount")]
                                public int PaymentDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置支付手续费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("fee_amount")]
                                public int PaymentFeeAmount { get; set; }
                            }

                            public class Tourist
                            {
                                /// <summary>
                                /// 获取或设置姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置加密手机号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phone")]
                                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                                public string? EncryptedMobileNumber { get; set; }

                                /// <summary>
                                /// 获取或设置加密身份证号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id_card")]
                                [System.Text.Json.Serialization.JsonPropertyName("id_card")]
                                public string? EncryptedIdCardNumber { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string SKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_sku_id")]
                        public string? OutSKUId { get; set; }

                        /// <summary>
                        /// 获取或设置预置码列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("codes")]
                        [System.Text.Json.Serialization.JsonPropertyName("codes")]
                        public string[] CodeList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount_info")]
                        public Types.Amount Amount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置出行人列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tourists")]
                        [System.Text.Json.Serialization.JsonPropertyName("tourists")]
                        public Types.Tourist[]? TouristList { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public Types.Order? Order { get; set; }
            }
        }
    }
}
