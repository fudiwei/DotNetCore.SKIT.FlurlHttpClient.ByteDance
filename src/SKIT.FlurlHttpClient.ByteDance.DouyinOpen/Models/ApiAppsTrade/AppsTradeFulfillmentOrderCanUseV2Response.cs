namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/fulfillment/order_can_use 接口的响应。</para>
    /// </summary>
    public class AppsTradeFulfillmentOrderCanUseV2Response : DouyinOpenResponse<AppsTradeFulfillmentOrderCanUseV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Certificate : AppsTradeFulfillmentQueryUserCertificatesV2Response.Types.Data.Types.Order.Types.__zz__Certificate
                    {
                        public static class Types
                        {
                            public class SKU : AppsTradeFulfillmentQueryUserCertificatesV2Response.Types.Data.Types.Order.Types.Certificate.Types.SKU
                            {
                            }

                            public class Amount : AppsTradeFulfillmentQueryUserCertificatesV2Response.Types.Data.Types.Order.Types.Certificate.Types.Amount
                            {
                            }

                            public class TimesCardInfo : AppsTradeFulfillmentQueryUserCertificatesV2Response.Types.Data.Types.Order.Types.Certificate.Types.TimesCardInfo
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_info")]
                        public Types.SKU? SKU { get; set; }

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public Types.Amount? Amount { get; set; }

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
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificates")]
                [System.Text.Json.Serialization.JsonPropertyName("certificates")]
                public List<Types.Certificate>? CertificateList { get; set; }

                /// <summary>
                /// 获取或设置是否可用。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_use")]
                [System.Text.Json.Serialization.JsonPropertyName("can_use")]
                public bool CanUse { get; set; }
            }
        }
    }
}
