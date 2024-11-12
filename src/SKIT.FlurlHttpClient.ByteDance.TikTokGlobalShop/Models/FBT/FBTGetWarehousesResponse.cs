namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fbt/{version}/warehouses 接口的响应。</para>
    /// </summary>
    public class FBTGetWarehousesResponse : TikTokShopResponse<FBTGetWarehousesResponse.Types.Data>
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
                            public class Address
                            {
                                /// <summary>
                                /// 获取或设置地区编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("region_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("region_code")]
                                public string RegionCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置邮编。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("postal_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("postal_code")]
                                public string PostalCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置州。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("state")]
                                [System.Text.Json.Serialization.JsonPropertyName("state")]
                                public string State { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置区。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("district")]
                                [System.Text.Json.Serialization.JsonPropertyName("district")]
                                public string District { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置市。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city")]
                                [System.Text.Json.Serialization.JsonPropertyName("city")]
                                public string City { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置地址行 1。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_line_1")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_line_1")]
                                public string? AddressLine1 { get; set; }

                                /// <summary>
                                /// 获取或设置地址行 2。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_line_2")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_line_2")]
                                public string? AddressLine2 { get; set; }

                                /// <summary>
                                /// 获取或设置地址行 3。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_line_3")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_line_3")]
                                public string? AddressLine3 { get; set; }
                            }

                            public class LogisticsService
                            {
                                /// <summary>
                                /// 获取或设置物流服务 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string Id { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置物流服务名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置是否订阅。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("subscribed")]
                                [System.Text.Json.Serialization.JsonPropertyName("subscribed")]
                                public bool IsSubscribed { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置 FBT 仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fbt_warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("fbt_warehouse_id")]
                        public string FBTWarehouseId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仓库 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_ids")]
                        public string[] WarehouseIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否订阅。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subscribed")]
                        [System.Text.Json.Serialization.JsonPropertyName("subscribed")]
                        public bool IsSubscribed { get; set; }

                        /// <summary>
                        /// 获取或设置地址列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("addresses")]
                        [System.Text.Json.Serialization.JsonPropertyName("addresses")]
                        public Types.Address[] AddressList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置物流服务列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_services")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_services")]
                        public Types.LogisticsService[] LogisticsServiceList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置仓库列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warehouses")]
                [System.Text.Json.Serialization.JsonPropertyName("warehouses")]
                public Types.Warehouse[] WarehouseList { get; set; } = default!;
            }
        }
    }
}
