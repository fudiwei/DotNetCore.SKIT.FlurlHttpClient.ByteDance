namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/shipping_service/get 接口的请求。</para>
    /// </summary>
    public class FulfillmentGetShippingServiceRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Dimension
            {
                /// <summary>
                /// 获取或设置长度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("length")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("length")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
                public decimal? Length { get; set; }

                /// <summary>
                /// 获取或设置宽度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("width")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("width")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
                public decimal? Width { get; set; }

                /// <summary>
                /// 获取或设置高度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("height")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("height")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberConverter))]
                public decimal? Height { get; set; }
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
    }
}
