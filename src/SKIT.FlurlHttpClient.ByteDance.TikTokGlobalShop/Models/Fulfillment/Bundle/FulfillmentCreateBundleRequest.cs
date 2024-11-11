using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/bundles 接口的请求。</para>
    /// </summary>
    public class FulfillmentCreateBundleRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202407</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202407;

        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ids")]
        public IList<string> OrderIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置交接方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("handover_method")]
        [System.Text.Json.Serialization.JsonPropertyName("handover_method")]
        public string HandoverMethod { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运输服务商 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_provider_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_id")]
        public string? ShippingProviderId { get; set; }

        /// <summary>
        /// 获取或设置物流单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tracking_number")]
        [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
        public string? TrackingNumber { get; set; }

        /// <summary>
        /// 获取或设置电话号码后四位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_tail_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_tail_number")]
        public string? PhoneTailNumber { get; set; }
    }
}
