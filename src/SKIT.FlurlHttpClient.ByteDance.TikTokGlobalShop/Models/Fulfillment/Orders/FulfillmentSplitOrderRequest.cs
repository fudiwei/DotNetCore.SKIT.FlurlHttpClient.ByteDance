using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/orders/{order_id}/split 接口的请求。</para>
    /// </summary>
    public class FulfillmentSplitOrderRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class SplittableGroup
            {
                /// <summary>
                /// 获取或设置分组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string SplittableGroupId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置订单行 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_line_item_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("order_line_item_ids")]
                public IList<string> OrderLineItemIdList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("splittable_groups")]
        [System.Text.Json.Serialization.JsonPropertyName("splittable_groups")]
        public IList<Types.SplittableGroup> SplittableGroupList { get; set; } = new List<Types.SplittableGroup>();
    }
}
