namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /warehouse/list 接口的响应。</para>
    /// </summary>
    public class WarehouseListResponse : TikTokShopResponse<WarehouseListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Warehouse
                    {
                        public static class Types
                        {
                            public class Address : WarehouseSetAddressRequest.Types.Address
                            {
                                /// <summary>
                                /// 获取或设置创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                public long CreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置更新时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("update_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                                public long UpdateTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                        public long WarehouseId { get; set; }

                        /// <summary>
                        /// 获取或设置外部仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
                        public string OutWarehouseId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仓库名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仓库介绍。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("intro")]
                        [System.Text.Json.Serialization.JsonPropertyName("intro")]
                        public string Introduction { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仓库地址列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("addr")]
                        [System.Text.Json.Serialization.JsonPropertyName("addr")]
                        public Types.Address[]? AddressList { get; set; }

                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        public int ShopId { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置仓库列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warehouses")]
                [System.Text.Json.Serialization.JsonPropertyName("warehouses")]
                public Types.Warehouse[] WarehouseList { get; set; } = default!;

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
