namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/fulfillment/query_user_certificates 接口的响应。</para>
    /// </summary>
    public class AppsTradeFulfillmentQueryUserCertificatesV2Response : DouyinOpenResponse<AppsTradeFulfillmentQueryUserCertificatesV2Response.Types.Data>
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
                            public class Certificate
                            {
                                public static class Types
                                {
                                    public class SKU
                                    {
                                        /// <summary>
                                        /// 获取或设置商品 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("spu_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
                                        public string? SPUId { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家商品 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("out_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("out_id")]
                                        public string? OutSPUId { get; set; }

                                        /// <summary>
                                        /// 获取或设置 SKU ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sku_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                        public string SKUId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置商家 SKU ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("third_sku_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("third_sku_id")]
                                        public string? OutSKUId { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("title")]
                                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                                        public string Title { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置团购类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("groupon_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("groupon_type")]
                                        public int GrouponType { get; set; }

                                        /// <summary>
                                        /// 获取或设置市场价（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("market_price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("market_price")]
                                        public int MarketPrice { get; set; }

                                        /// <summary>
                                        /// 获取或设置团购售卖开始时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sold_start_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sold_start_time")]
                                        public int SoldStartTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家团购账号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("account_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                                        public string? AccountId { get; set; }
                                    }

                                    public class Amount
                                    {
                                        /// <summary>
                                        /// 获取或设置原始金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("original_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("original_amount")]
                                        public int OriginalAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置实付金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("pay_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                                        public int PayAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家营销金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("merchant_ticket_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("merchant_ticket_amount")]
                                        public int? MerchantTicketAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置支付优惠金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("payment_discount_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("payment_discount_amount")]
                                        public int? PaymentDiscountAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置券实付金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("coupon_pay_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("coupon_pay_amount")]
                                        public int? CouponPayAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置平台补贴金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("platform_ticket_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("platform_ticket_amount")]
                                        public int? PlatformTicketAmount { get; set; }
                                    }

                                    public class TimesCardInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置总次数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("total_times")]
                                        [System.Text.Json.Serialization.JsonPropertyName("total_times")]
                                        public int TotalTimes { get; set; }

                                        /// <summary>
                                        /// 获取或设置可用次数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("usable_times")]
                                        [System.Text.Json.Serialization.JsonPropertyName("usable_times")]
                                        public int UsableTimes { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置券 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("certificate_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                                public string CertificateId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置生效时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                public long StartTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置过期时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("expire_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                                public long ExpireTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置券码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("code")]
                                [System.Text.Json.Serialization.JsonPropertyName("code")]
                                public string? Code { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_info")]
                                public Types.SKU SKU { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置金额信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                public Types.Amount Amount { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置次卡信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("times_card_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("times_card_info")]
                                public Types.TimesCardInfo? TimesCardInfo { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificates")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificates")]
                        public Types.Certificate[] CertificateList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否可用。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_use")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_use")]
                        public bool CanUse { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orders")]
                [System.Text.Json.Serialization.JsonPropertyName("orders")]
                public Types.Order[] OrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
