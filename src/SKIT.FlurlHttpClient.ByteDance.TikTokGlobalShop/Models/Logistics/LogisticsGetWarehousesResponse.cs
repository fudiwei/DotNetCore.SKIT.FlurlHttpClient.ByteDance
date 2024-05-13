namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /logistics/{version}/warehouses 接口的响应。</para>
    /// </summary>
    public class LogisticsGetWarehousesResponse : TikTokShopResponse<LogisticsGetWarehousesResponse.Types.Data>
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
                                /// 获取或设置完整地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("full_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("full_address")]
                                public string FullAddress { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置地区编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("region_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("region_code")]
                                public string RegionCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置地区。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("region")]
                                [System.Text.Json.Serialization.JsonPropertyName("region")]
                                public string Region { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置州/省。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("state")]
                                [System.Text.Json.Serialization.JsonPropertyName("state")]
                                public string State { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置市。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city")]
                                [System.Text.Json.Serialization.JsonPropertyName("city")]
                                public string City { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置县。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("distict")]
                                [System.Text.Json.Serialization.JsonPropertyName("distict")]
                                public string District { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置镇。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("town")]
                                [System.Text.Json.Serialization.JsonPropertyName("town")]
                                public string Town { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置电话号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phone_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                                public string PhoneNumber { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置联系人姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("contact_person")]
                                [System.Text.Json.Serialization.JsonPropertyName("contact_person")]
                                public string ContactName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置邮编。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("postal_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("postal_code")]
                                public string PostalCode { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string WarehouseId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仓库名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仓库类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仓库子类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_type")]
                        public string SubType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置有效状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("effect_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("effect_status")]
                        public string EffectStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否默认。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_default")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_default")]
                        public bool IsDefault { get; set; }

                        /// <summary>
                        /// 获取或设置地址信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public Types.Address Address { get; set; } = default!;
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
