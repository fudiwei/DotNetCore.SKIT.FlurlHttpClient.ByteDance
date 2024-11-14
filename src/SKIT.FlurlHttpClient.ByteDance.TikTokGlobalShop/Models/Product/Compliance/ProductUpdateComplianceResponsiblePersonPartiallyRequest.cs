namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/compliance/responsible_persons/{responsible_person_id}/partial_edit 接口的请求。</para>
    /// </summary>
    public class ProductUpdateComplianceResponsiblePersonPartiallyRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class PhoneNumber : ProductCreateComplianceResponsiblePersonRequest.Types.PhoneNumber
            {
            }

            public class Address : ProductCreateComplianceResponsiblePersonRequest.Types.Address
            {
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
        /// 获取或设置责任人 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ResponsiblePersonId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置责任人名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置邮件地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置电话号码信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public Types.PhoneNumber? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public Types.Address? Address { get; set; }
    }
}
