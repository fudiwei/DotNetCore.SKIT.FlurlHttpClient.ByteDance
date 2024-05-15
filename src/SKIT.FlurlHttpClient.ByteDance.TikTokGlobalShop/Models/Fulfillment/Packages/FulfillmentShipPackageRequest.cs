namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/packages/{package_id}/ship 接口的请求。</para>
    /// </summary>
    public class FulfillmentShipPackageRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class TimeSlot
            {
                /// <summary>
                /// 获取或设置开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long? EndTimestamp { get; set; }
            }

            public class Shipment
            {
                /// <summary>
                /// 获取或设置物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tracking_number")]
                [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
                public string TrackingNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置运输服务商 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_provider_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_id")]
                public string ShippingProviderId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置包裹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PackageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置交接方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("handover_method")]
        [System.Text.Json.Serialization.JsonPropertyName("handover_method")]
        public string? HandoverMethod { get; set; }

        /// <summary>
        /// 获取或设置取件时间段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pickup_slot")]
        [System.Text.Json.Serialization.JsonPropertyName("pickup_slot")]
        public Types.TimeSlot? PickupTimeSlot { get; set; }

        /// <summary>
        /// 获取或设置自行运输信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("self_shipment")]
        [System.Text.Json.Serialization.JsonPropertyName("self_shipment")]
        public Types.Shipment? Shipment { get; set; }
    }
}
