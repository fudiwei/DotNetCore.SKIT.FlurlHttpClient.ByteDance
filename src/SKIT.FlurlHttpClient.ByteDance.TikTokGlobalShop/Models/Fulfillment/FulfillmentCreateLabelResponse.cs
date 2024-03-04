namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/create_label 接口的响应。</para>
    /// </summary>
    public class FulfillmentCreateLabelResponse : TikTokShopResponse<FulfillmentCreateLabelResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Dimension : FulfillmentGetShippingServiceResponse.Types.Data.Types.Dimension
                    {
                    }

                    public class ShippingServiceInfo : FulfillmentGetShippingServiceResponse.Types.Data.Types.ShippingServiceInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string PackageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置重量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
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
                /// 获取或设置货运服务信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_service_info")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_service_info")]
                public Types.ShippingServiceInfo? ShippingServiceInfo { get; set; }
            }
        }
    }
}
