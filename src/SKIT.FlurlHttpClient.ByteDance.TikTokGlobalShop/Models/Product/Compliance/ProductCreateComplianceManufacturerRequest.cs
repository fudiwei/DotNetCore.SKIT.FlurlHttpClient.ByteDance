namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/compliance/manufacturers 接口的请求。</para>
    /// </summary>
    public class ProductCreateComplianceManufacturerRequest : TikTokShopRequest
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
                public string CountryCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置本地号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("local_number")]
                [System.Text.Json.Serialization.JsonPropertyName("local_number")]
                public string LocalNumber { get; set; } = string.Empty;
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
        /// 获取或设置制造商名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

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
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置电话号码信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public Types.PhoneNumber PhoneNumber { get; set; } = new Types.PhoneNumber();

        /// <summary>
        /// 获取或设置地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;
    }
}
