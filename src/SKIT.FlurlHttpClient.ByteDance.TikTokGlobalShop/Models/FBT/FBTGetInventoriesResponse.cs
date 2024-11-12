namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fbt/{version}/inventory/search 接口的响应。</para>
    /// </summary>
    public class FBTGetInventoriesResponse : TikTokShopResponse<FBTGetInventoriesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Inventory
                    {
                        public static class Types
                        {
                            public class Goods
                            {
                                public static class Types
                                {
                                    public class SKU
                                    {
                                        public static class Types
                                        {
                                            public class OnHandDetail
                                            {
                                                /// <summary>
                                                /// 获取或设置总数量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("total_quantity")]
                                                [System.Text.Json.Serialization.JsonPropertyName("total_quantity")]
                                                public int TotalQuantity { get; set; }

                                                /// <summary>
                                                /// 获取或设置可用数量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("available_quantity")]
                                                [System.Text.Json.Serialization.JsonPropertyName("available_quantity")]
                                                public int AvailableQuantity { get; set; }

                                                /// <summary>
                                                /// 获取或设置退回数量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("reserved_quantity")]
                                                [System.Text.Json.Serialization.JsonPropertyName("reserved_quantity")]
                                                public int ReservedQuantity { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置 SKU ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                                        public string SKUId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置详细信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("on_hand_detail")]
                                        [System.Text.Json.Serialization.JsonPropertyName("on_hand_detail")]
                                        public Types.OnHandDetail? OnHandDetail { get; set; }
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
                                /// 获取或设置 SKU 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("skus")]
                                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                                public Types.SKU[] SKUList { get; set; } = default!;
                            }

                            public class OnHandDetail
                            {
                                /// <summary>
                                /// 获取或设置总数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_quantity")]
                                public int TotalQuantity { get; set; }

                                /// <summary>
                                /// 获取或设置可用数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("available_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("available_quantity")]
                                public int AvailableQuantity { get; set; }

                                /// <summary>
                                /// 获取或设置退回数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reserved_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("reserved_quantity")]
                                public int ReservedQuantity { get; set; }

                                /// <summary>
                                /// 获取或设置不可售数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("unfulfillable_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("unfulfillable_quantity")]
                                public int UnfulfillableQuantity { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置 FBT 仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fbt_warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("fbt_warehouse_id")]
                        public string FBTWarehouseId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置货物信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods")]
                        public Types.Goods Goods { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置在途货物数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("in_transit_quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("in_transit_quantity")]
                        public int InTransitQuantity { get; set; }

                        /// <summary>
                        /// 获取或设置详细信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("on_hand_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("on_hand_detail")]
                        public Types.OnHandDetail? OnHandDetail { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置库存列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory")]
                public Types.Inventory[] InventoryList { get; set; } = default!;

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
