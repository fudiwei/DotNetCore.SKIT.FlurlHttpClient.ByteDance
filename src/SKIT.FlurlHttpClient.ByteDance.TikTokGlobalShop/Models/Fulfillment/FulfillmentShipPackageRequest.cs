namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/rts 接口的请求。</para>
    /// </summary>
    public class FulfillmentShipPackageRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class PickupInfo
            {
                /// <summary>
                /// 获取或设置开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pick_up_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pick_up_start_time")]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pick_up_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pick_up_end_time")]
                public long? EndTimestamp { get; set; }
            }

            public class SelfShipment
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
        [Newtonsoft.Json.JsonProperty("package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
        public string PackageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提货方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pick_up_type")]
        [System.Text.Json.Serialization.JsonPropertyName("pick_up_type")]
        public int? PickupType { get; set; }

        /// <summary>
        /// 获取或设置上门提货信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pick_up")]
        [System.Text.Json.Serialization.JsonPropertyName("pick_up")]
        public Types.PickupInfo? PickupInfo { get; set; }

        /// <summary>
        /// 获取或设置自配送信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("self_shipment")]
        [System.Text.Json.Serialization.JsonPropertyName("self_shipment")]
        public Types.SelfShipment? SelfShipment { get; set; }
    }
}
