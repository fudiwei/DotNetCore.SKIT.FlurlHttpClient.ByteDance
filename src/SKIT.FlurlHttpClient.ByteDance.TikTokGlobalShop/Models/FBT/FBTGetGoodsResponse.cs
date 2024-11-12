namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fbt/{version}/goods/search 接口的响应。</para>
    /// </summary>
    public class FBTGetGoodsResponse : TikTokShopResponse<FBTGetGoodsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Goods
                    {
                        public static class Types
                        {
                            public class BarCode
                            {
                                /// <summary>
                                /// 获取或设置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("code")]
                                [System.Text.Json.Serialization.JsonPropertyName("code")]
                                public string Code { get; set; } = default!;
                            }

                            public class MerchantDeclarationInfo
                            {
                                public static class Types
                                {
                                    public class Dimension
                                    {
                                        /// <summary>
                                        /// 获取或设置单位。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("unit")]
                                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                                        public string Unit { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置长度。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("length")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("length")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? Length { get; set; }

                                        /// <summary>
                                        /// 获取或设置宽度。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("width")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? Width { get; set; }

                                        /// <summary>
                                        /// 获取或设置高度。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("height")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? Height { get; set; }
                                    }

                                    public class Weight
                                    {
                                        /// <summary>
                                        /// 获取或设置单位。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("unit")]
                                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                                        public string Unit { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置重量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? Value { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置尺寸信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("dimension")]
                                [System.Text.Json.Serialization.JsonPropertyName("dimension")]
                                public Types.Dimension? Dimension { get; set; }

                                /// <summary>
                                /// 获取或设置重量信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("weight")]
                                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                                public Types.Weight? Weight { get; set; }
                            }

                            public class WarehouseConfirmationInfo
                            {
                                public static class Types
                                {
                                    public class Dimension : MerchantDeclarationInfo.Types.Dimension
                                    {
                                    }

                                    public class Weight : MerchantDeclarationInfo.Types.Weight
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置尺寸信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("dimension")]
                                [System.Text.Json.Serialization.JsonPropertyName("dimension")]
                                public Types.Dimension? Dimension { get; set; }

                                /// <summary>
                                /// 获取或设置重量信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("weight")]
                                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                                public Types.Weight? Weight { get; set; }
                            }

                            public class SKU
                            {
                                public static class Types
                                {
                                    public class Product
                                    {
                                        /// <summary>
                                        /// 获取或设置商品 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                                        public string ProductId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置商品名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置图片 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("image_url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                                        public string ImageUrl { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                                public string ImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product")]
                                [System.Text.Json.Serialization.JsonPropertyName("product")]
                                public Types.Product Product { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置销售地区编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("regions")]
                                [System.Text.Json.Serialization.JsonPropertyName("regions")]
                                public string[] RegionCodeList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置是否匹配。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("matched")]
                                [System.Text.Json.Serialization.JsonPropertyName("matched")]
                                public bool IsMatched { get; set; }
                            }

                            public class LotExpirationInfo
                            {
                                /// <summary>
                                /// 获取或设置是否受批次控制。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_lot_control")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_lot_control")]
                                public bool IsLotControl { get; set; }

                                /// <summary>
                                /// 获取或设置是否受过期管理。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_expiration_management")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_expiration_management")]
                                public bool IsExpirationManagement { get; set; }

                                /// <summary>
                                /// 获取或设置保质期天数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shelf_life_days")]
                                [System.Text.Json.Serialization.JsonPropertyName("shelf_life_days")]
                                public int? ShelfLifeDays { get; set; }

                                /// <summary>
                                /// 获取或设置入库截止天数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("inbound_cutoff_days")]
                                [System.Text.Json.Serialization.JsonPropertyName("inbound_cutoff_days")]
                                public int? InboundCutOffDays { get; set; }

                                /// <summary>
                                /// 获取或设置过期提醒天数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("expiration_alert_days")]
                                [System.Text.Json.Serialization.JsonPropertyName("expiration_alert_days")]
                                public int? ExpirationAlertDays { get; set; }

                                /// <summary>
                                /// 获取或设置销售截止天数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sales_cutoff_days")]
                                [System.Text.Json.Serialization.JsonPropertyName("sales_cutoff_days")]
                                public int? SalesCutOffDays { get; set; }

                                /// <summary>
                                /// 获取或设置过期库存处理方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("handling_method")]
                                [System.Text.Json.Serialization.JsonPropertyName("handling_method")]
                                public string? HandlingMethod { get; set; }

                                /// <summary>
                                /// 获取或设置退货周期类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_cycle")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_cycle")]
                                public string? ReturnCycleType { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置货物 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string GoodsId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商家自定义货物标识符。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reference_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("reference_code")]
                        public string ReferenceCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置货物名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置条码列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("barcodes")]
                        [System.Text.Json.Serialization.JsonPropertyName("barcodes")]
                        public Types.BarCode[]? BarCodeList { get; set; }

                        /// <summary>
                        /// 获取或设置图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                        public string ImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商家声明信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_declaration_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_declaration_info")]
                        public Types.MerchantDeclarationInfo? MerchantDeclarationInfo { get; set; }

                        /// <summary>
                        /// 获取或设置仓库确认信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_confirmation_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_confirmation_info")]
                        public Types.WarehouseConfirmationInfo? WarehouseConfirmationInfo { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKUList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置货物批次控制和到期管理信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lot_expiration_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("lot_expiration_info")]
                        public Types.LotExpirationInfo? LotExpirationInfo { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置货物列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods")]
                [System.Text.Json.Serialization.JsonPropertyName("goods")]
                public Types.Goods[] GoodsList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置下一页分页令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_page_token")]
                [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
                public string? NextPageToken { get; set; }
            }
        }
    }
}
