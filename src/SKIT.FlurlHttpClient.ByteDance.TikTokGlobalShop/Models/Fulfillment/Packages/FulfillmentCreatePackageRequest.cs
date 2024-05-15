using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/packages 接口的请求。</para>
    /// </summary>
    public class FulfillmentCreatePackageRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class PackageDimension : ProductCreateProductRequest.Types.PackageDimension
            {
            }

            public class PackageWeight : ProductCreateProductRequest.Types.PackageWeight
            {
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单行 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_line_item_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("order_line_item_ids")]
        public IList<string>? OrderLineItemIdList { get; set; }

        /// <summary>
        /// 获取或设置运输服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shipping_service_id")]
        public string? ShippingServiceId { get; set; }

        /// <summary>
        /// 获取或设置包裹尺寸信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dimension")]
        [System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public Types.PackageDimension? PackageDimension { get; set; }

        /// <summary>
        /// 获取或设置包裹重量信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight")]
        [System.Text.Json.Serialization.JsonPropertyName("weight")]
        public Types.PackageWeight? PackageWeight { get; set; }
    }
}
