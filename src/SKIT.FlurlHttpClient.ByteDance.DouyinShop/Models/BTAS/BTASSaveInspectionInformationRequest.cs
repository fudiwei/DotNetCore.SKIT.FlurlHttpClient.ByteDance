namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /btas/saveInspectionInfo 接口的请求。</para>
    /// </summary>
    public class BTASSaveInspectionInformationRequest : DouyinShopRequest
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
        public string ProductOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_code")]
        [System.Text.Json.Serialization.JsonPropertyName("order_code")]
        public string OrderCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_status")]
        [System.Text.Json.Serialization.JsonPropertyName("service_status")]
        public int ServiceStatus { get; set; }

        /// <summary>
        /// 获取或设置需要修改的物流单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_send_logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("base_send_logistics_code")]
        public string? BaseSendLogisticsNumber { get; set; }

        /// <summary>
        /// 获取或设置送检方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_type")]
        [System.Text.Json.Serialization.JsonPropertyName("send_type")]
        public int SendType { get; set; }

        /// <summary>
        /// 获取或设置物流公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_logistics_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("send_logistics_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? SendLogisticsCompanyId { get; set; }

        /// <summary>
        /// 获取或设置物流公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_logistics_company_code")]
        [System.Text.Json.Serialization.JsonPropertyName("send_logistics_company_code")]
        public string? SendLogisticsCompanyCode { get; set; }

        /// <summary>
        /// 获取或设置物流运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("send_logistics_code")]
        public string? SendLogisticsNumber { get; set; }

        /// <summary>
        /// 获取或设置是否自发货。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_shipping_self")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_shipping_self")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsShippingSelf { get; set; }

        /// <summary>
        /// 获取或设置发货方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_logistics_type")]
        [System.Text.Json.Serialization.JsonPropertyName("shipping_logistics_type")]
        public int? ShippingLogisticsType { get; set; }

        /// <summary>
        /// 获取或设置保价金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insurance_cost")]
        [System.Text.Json.Serialization.JsonPropertyName("insurance_cost")]
        public int? InsuranceCost { get; set; }

        /// <summary>
        /// 获取或设置优先类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_intercept_type")]
        [System.Text.Json.Serialization.JsonPropertyName("return_intercept_type")]
        public int ReturnInterceptType { get; set; }

        /// <summary>
        /// 获取或设置邮寄类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_type")]
        [System.Text.Json.Serialization.JsonPropertyName("return_type")]
        public int? ReturnType { get; set; }
    }
}
