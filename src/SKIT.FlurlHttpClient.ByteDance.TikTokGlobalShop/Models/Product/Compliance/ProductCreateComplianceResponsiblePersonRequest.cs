namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/compliance/responsible_persons 接口的请求。</para>
    /// </summary>
    public class ProductCreateComplianceResponsiblePersonRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class PhoneNumber : ProductCreateComplianceManufacturerRequest.Types.PhoneNumber
            {
            }

            public class Address
            {
                /// <summary>
                /// 获取或设置邮编。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("postal_code")]
                [System.Text.Json.Serialization.JsonPropertyName("postal_code")]
                public string PostalCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置国家。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country")]
                [System.Text.Json.Serialization.JsonPropertyName("country")]
                public string Country { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置省。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string Province { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string City { get; set; } = string.Empty;

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
        /// 获取或设置 API 版本号。
        /// <para>默认值：202409</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202409;

        /// <summary>
        /// 获取或设置责任人名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置邮件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置电话号码信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public Types.PhoneNumber PhoneNumber { get; set; } = new Types.PhoneNumber();

        /// <summary>
        /// 获取或设置地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public Types.Address Address { get; set; } = new Types.Address();
    }
}
