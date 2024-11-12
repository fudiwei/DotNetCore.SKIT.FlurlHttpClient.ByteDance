namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fbt/{version}/inventory_records/search 接口的响应。</para>
    /// </summary>
    public class FBTGetInventoryRecordsResponse : TikTokShopResponse<FBTGetInventoryRecordsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class InventoryRecord
                    {
                        public static class Types
                        {
                            public class Goods
                            {
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
                            }

                            public class Order
                            {
                                /// <summary>
                                /// 获取或设置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string Id { get; set; } = default!;
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
                        /// 获取或设置单据信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order")]
                        [System.Text.Json.Serialization.JsonPropertyName("order")]
                        public Types.Order Order { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置库存货物类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("inventory_goods_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("inventory_goods_type")]
                        public string InventoryGoodsType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置初始库存数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("initial_on_hand_quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("initial_on_hand_quantity")]
                        public int InitialOnHandQuantity { get; set; }

                        /// <summary>
                        /// 获取或设置最终库存数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("final_on_hand_quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("final_on_hand_quantity")]
                        public int FinalOnHandQuantity { get; set; }

                        /// <summary>
                        /// 获取或设置变化的库存数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("changed_quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("changed_quantity")]
                        public int ChangedQuantity { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置库存记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory_records")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory_records")]
                public Types.InventoryRecord[] InventoryRecordList { get; set; } = default!;

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
