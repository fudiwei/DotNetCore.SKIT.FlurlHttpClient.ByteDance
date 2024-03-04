namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/create_label 接口的请求。</para>
    /// </summary>
    public class FulfillmentCreateLabelRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Dimension : FulfillmentGetShippingServiceRequest.Types.Dimension
            {
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? ApiVersion { get; set; } = "202304";

        /// <summary>
        /// 获取或设置包裹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
        public string PackageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置重量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("weight")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
        public decimal? Weight { get; set; }

        /// <summary>
        /// 获取或设置重量单位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight_unit")]
        [System.Text.Json.Serialization.JsonPropertyName("weight_unit")]
        public int? WeightUnit { get; set; }

        /// <summary>
        /// 获取或设置尺寸信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dimension")]
        [System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public Types.Dimension? Dimension { get; set; }

        /// <summary>
        /// 获取或设置尺寸单位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dimension_unit")]
        [System.Text.Json.Serialization.JsonPropertyName("dimension_unit")]
        public int? DimensionUnit { get; set; }

        /// <summary>
        /// 获取或设置货运服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shipping_service_id")]
        public string? ShippingServiceId { get; set; }
    }
}
