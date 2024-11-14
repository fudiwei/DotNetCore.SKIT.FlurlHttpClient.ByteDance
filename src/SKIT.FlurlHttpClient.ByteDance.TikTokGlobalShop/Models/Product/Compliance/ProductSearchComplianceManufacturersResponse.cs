namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/compliance/manufacturers/search 接口的响应。</para>
    /// </summary>
    public class ProductSearchComplianceManufacturersResponse : TikTokShopResponse<ProductSearchComplianceManufacturersResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Manufacturer
                    {
                        public static class Types
                        {
                            public class PhoneNumber
                            {
                                /// <summary>
                                /// 获取或设置国家地区号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("country_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("country_code")]
                                public string CountryCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置本地号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("local_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("local_number")]
                                public string LocalNumber { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置制造商 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ManufacturerId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置制造商名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置制造商注册商业名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("registered_trade_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("registered_trade_name")]
                        public string? RegisteredTradeName { get; set; }

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
                        /// 获取或设置地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string Address { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置制造商列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manufacturers")]
                [System.Text.Json.Serialization.JsonPropertyName("manufacturers")]
                public Types.Manufacturer[] ManufacturerList { get; set; } = default!;

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
