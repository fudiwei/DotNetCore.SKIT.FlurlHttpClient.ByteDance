using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/logisticsAddSinglePack 接口的请求。</para>
    /// </summary>
    public class OrderLogisticsAddSinglePackageRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class ShippedOrder
            {
                /// <summary>
                /// 获取或设置子订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipped_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shipped_order_id")]
                public string ShippedOrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置待发货数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipped_num")]
                [System.Text.Json.Serialization.JsonPropertyName("shipped_num")]
                public int ShippedCount { get; set; }

                /// <summary>
                /// 获取或设置货物 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipped_item_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("shipped_item_ids")]
                public IList<string>? ShippedItemIdList { get; set; }
            }

            public class OrderSerialNumber
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置序列号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("serial_number_list")]
                [System.Text.Json.Serialization.JsonPropertyName("serial_number_list")]
                public IList<string> SerialNumberList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
        public IList<string> OrderIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置需要发货的子订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipped_order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("shipped_order_info")]
        public IList<Types.ShippedOrder> ShippedOrderList { get; set; } = new List<Types.ShippedOrder>();

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
        public string LogisticsNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string RequestId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发货地址 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id")]
        [System.Text.Json.Serialization.JsonPropertyName("address_id")]
        public int AddressId { get; set; }

        /// <summary>
        /// 获取或设置是否拒绝退款申请。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_refund_reject")]
        [System.Text.Json.Serialization.JsonPropertyName("is_refund_reject")]
        public bool? IsRefundRejected { get; set; }

        /// <summary>
        /// 获取或设置序列号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_serial_number")]
        [System.Text.Json.Serialization.JsonPropertyName("order_serial_number")]
        public IList<Types.OrderSerialNumber>? SerialNumberList { get; set; }
    }
}
