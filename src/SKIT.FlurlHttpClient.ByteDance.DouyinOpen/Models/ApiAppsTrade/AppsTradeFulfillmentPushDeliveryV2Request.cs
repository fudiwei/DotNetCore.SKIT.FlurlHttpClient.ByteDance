using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/fulfillment/push_delivery 接口的请求。</para>
    /// </summary>
    public class AppsTradeFulfillmentPushDeliveryV2Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class ItemOrder
            {
                /// <summary>
                /// 获取或设置商品单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                public string ItemOrderId { get; set; } = string.Empty;
            }

            public class POIInfo : AppsTradeFulfillmentDeliveryVerifyV2Request.Types.POIInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置开发者订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("item_order_list")]
        public IList<Types.ItemOrder> ItemOrderList { get; set; } = new List<Types.ItemOrder>();

        /// <summary>
        /// 获取或设置是否整单核销。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_all")]
        [System.Text.Json.Serialization.JsonPropertyName("use_all")]
        public bool? IsUseAll { get; set; }

        /// <summary>
        /// 获取或设置商铺 POI 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_info")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("poi_info")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public Types.POIInfo? POIInfo { get; set; }
    }
}
