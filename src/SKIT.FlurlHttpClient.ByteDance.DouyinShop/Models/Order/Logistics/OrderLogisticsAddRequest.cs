using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/logisticsAdd 接口的请求。</para>
    /// </summary>
    public class OrderLogisticsAddRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置物流公司 ID。与字段 <see cref="CompanyCode"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_id")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// 获取或设置物流公司编码。与字段 <see cref="CompanyId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_code")]
        [System.Text.Json.Serialization.JsonPropertyName("company_code")]
        public string? CompanyCode { get; set; }

        /// <summary>
        /// 获取或设置物流公司名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company")]
        [System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// 获取或设置快递单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
        public string? LogisticsNumber { get; set; }

        /// <summary>
        /// 获取或设置是否拒绝退款申请。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_refund_reject")]
        [System.Text.Json.Serialization.JsonPropertyName("is_refund_reject")]
        public bool? IsRefundRejected { get; set; }

        /// <summary>
        /// 获取或设置序列号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serial_number_list")]
        [System.Text.Json.Serialization.JsonPropertyName("serial_number_list")]
        public IList<string>? SerialNumberList { get; set; }
    }
}
