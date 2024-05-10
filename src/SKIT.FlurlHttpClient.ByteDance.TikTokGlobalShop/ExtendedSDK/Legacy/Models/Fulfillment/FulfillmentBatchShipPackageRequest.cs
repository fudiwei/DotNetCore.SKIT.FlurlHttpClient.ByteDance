using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/batch_rts 接口的请求。</para>
    /// </summary>
    public class FulfillmentBatchShipPackageRequest : TikTokShopLegacyRequest
    {
        public static class Types
        {
            public class Package
            {
                public static class Types
                {
                    public class PickupInfo : FulfillmentShipPackageRequest.Types.PickupInfo
                    {
                    }

                    public class SelfShipment : FulfillmentShipPackageRequest.Types.SelfShipment
                    {
                    }
                }

                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                public string PackageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置提货类型。
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

        /// <summary>
        /// 获取或设置包裹列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_list")]
        [System.Text.Json.Serialization.JsonPropertyName("package_list")]
        public IList<Types.Package> PackageList { get; set; } = new List<Types.Package>();
    }
}
