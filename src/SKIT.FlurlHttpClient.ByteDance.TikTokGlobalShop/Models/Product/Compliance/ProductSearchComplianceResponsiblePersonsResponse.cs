namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/compliance/responsible_persons/search 接口的响应。</para>
    /// </summary>
    public class ProductSearchComplianceResponsiblePersonsResponse : TikTokShopResponse<ProductSearchComplianceResponsiblePersonsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ResponsiblePerson
                    {
                        public static class Types
                        {
                            public class PhoneNumber : ProductSearchComplianceManufacturersResponse.Types.Data.Types.Manufacturer.Types.PhoneNumber
                            {
                            }

                            public class Address
                            {
                                /// <summary>
                                /// 获取或设置邮编。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("postal_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("postal_code")]
                                public string PostalCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置国家。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("country")]
                                [System.Text.Json.Serialization.JsonPropertyName("country")]
                                public string Country { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置省。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province")]
                                [System.Text.Json.Serialization.JsonPropertyName("province")]
                                public string Province { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置市。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city")]
                                [System.Text.Json.Serialization.JsonPropertyName("city")]
                                public string City { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置区。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("district")]
                                [System.Text.Json.Serialization.JsonPropertyName("district")]
                                public string? District { get; set; }

                                /// <summary>
                                /// 获取或设置街道地址行 1。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("street_address_line1")]
                                [System.Text.Json.Serialization.JsonPropertyName("street_address_line1")]
                                public string? StreetAddressLine1 { get; set; }

                                /// <summary>
                                /// 获取或设置街道地址行 2。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("street_address_line2")]
                                [System.Text.Json.Serialization.JsonPropertyName("street_address_line2")]
                                public string? StreetAddressLine2 { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置责任人 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ResponsiblePersonId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置责任人名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置邮件地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("email")]
                        [System.Text.Json.Serialization.JsonPropertyName("email")]
                        public string Email { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置电话号码信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                        public Types.PhoneNumber PhoneNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置地址信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public Types.Address Address { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置责任人列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("responsible_persons")]
                [System.Text.Json.Serialization.JsonPropertyName("responsible_persons")]
                public Types.ResponsiblePerson[] ResponsiblePersonList { get; set; } = default!;

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
