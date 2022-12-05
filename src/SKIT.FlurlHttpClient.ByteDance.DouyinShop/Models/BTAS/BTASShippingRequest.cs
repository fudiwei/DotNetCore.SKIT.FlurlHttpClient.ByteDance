namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /btas/shipping 接口的请求。</para>
    /// </summary>
    public class BTASShippingRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_order_id")]
        public string? ProductOrderId { get; set; }

        /// <summary>
        /// 获取或设置订单码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_code")]
        [System.Text.Json.Serialization.JsonPropertyName("order_code")]
        public string? OrderCode { get; set; }

        /// <summary>
        /// 获取或设置服务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_status")]
        [System.Text.Json.Serialization.JsonPropertyName("service_status")]
        public int ServiceStatus { get; set; }

        /// <summary>
        /// 获取或设置需要修改的物流单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_shipping_logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("base_shipping_logistics_code")]
        public string? BaseShippingLogisticsNumber { get; set; }

        /// <summary>
        /// 获取或设置物流公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_logistics_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("shipping_logistics_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? ShippingLogisticsCompanyId { get; set; }

        /// <summary>
        /// 获取或设置物流公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_logistics_company_code")]
        [System.Text.Json.Serialization.JsonPropertyName("shipping_logistics_company_code")]
        public string? ShippingLogisticsCompanyCode { get; set; }

        /// <summary>
        /// 获取或设置物流运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("shipping_logistics_code")]
        public string? ShippingLogisticsNumber { get; set; }
    }
}
