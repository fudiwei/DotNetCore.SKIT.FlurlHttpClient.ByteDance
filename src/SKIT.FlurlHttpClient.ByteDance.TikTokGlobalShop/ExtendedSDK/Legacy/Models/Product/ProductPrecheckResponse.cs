namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /products/pre_check 接口的响应。</para>
    /// </summary>
    public class ProductPrecheckResponse : TikTokShopLegacyResponse<ProductPrecheckResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ShopInfo
                    {
                        public static class Types
                        {
                            public class GNEInfo
                            {
                                /// <summary>
                                /// 获取或设置产品数量限制 JSON 字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_quantity_limit")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_quantity_limit")]
                                public string ProductQuantityLimitString { get; set; } = default!;
                            }

                            public class LogisticsInfo
                            {
                                /// <summary>
                                /// 获取或设置发货仓库 JSON 字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_warehouse")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_warehouse")]
                                public string DeliveryWarehouseLimitString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置退货仓库 JSON 字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_warehouse")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_warehouse")]
                                public string ReturnWarehouseLimitString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置货运模板 JSON 字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_template")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_template")]
                                public string ShippingTemplateJson { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置物流服务 JSON 字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("logistics_service")]
                                [System.Text.Json.Serialization.JsonPropertyName("logistics_service")]
                                public string LogisticsServiceJson { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置店铺状态 JSON 字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_status")]
                        public string ShopInfoJson { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置税费信息 JSON 字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_info")]
                        public string TaxInfoJson { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 GNE 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gne_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("gne_info")]
                        public Types.GNEInfo GNEInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置物流信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_info")]
                        public Types.LogisticsInfo LogisticsInfo { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置店铺信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_info")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_info")]
                public Types.ShopInfo ShopInfo { get; set; } = default!;
            }
        }
    }
}
