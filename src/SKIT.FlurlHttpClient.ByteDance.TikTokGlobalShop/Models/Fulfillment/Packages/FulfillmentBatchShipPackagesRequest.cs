using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/packages/ship 接口的请求。</para>
    /// </summary>
    public class FulfillmentBatchShipPackagesRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Package
            {
                public static class Types
                {
                    public class TimeSlot : FulfillmentShipPackageRequest.Types.TimeSlot
                    {
                    }

                    public class Shipment : FulfillmentShipPackageRequest.Types.Shipment
                    {
                    }
                }

                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
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

        /// <summary>
        /// 获取或设置包裹列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("packages")]
        [System.Text.Json.Serialization.JsonPropertyName("packages")]
        public IList<Types.Package> PackageList { get; set; } = new List<Types.Package>();
    }
}
