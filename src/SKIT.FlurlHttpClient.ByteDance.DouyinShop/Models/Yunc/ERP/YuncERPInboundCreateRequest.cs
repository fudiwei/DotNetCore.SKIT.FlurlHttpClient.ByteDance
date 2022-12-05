using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/erpInboundCreate 接口的请求。</para>
    /// </summary>
    public class YuncERPInboundCreateRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class OrderLine
            {
                /// <summary>
                /// 获取或设置入库单行号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("line_no")]
                [System.Text.Json.Serialization.JsonPropertyName("line_no")]
                public string LineNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置入库单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_order_no")]
                public string BusinessOrderNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置货品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_code")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_code")]
                public string CargoCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置库存类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory_type")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory_type")]
                public int InventoryType { get; set; }

                /// <summary>
                /// 获取或设置库存状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory_status")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory_status")]
                public int InventoryStatus { get; set; }

                /// <summary>
                /// 获取或设置 ERP SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("erp_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("erp_sku_id")]
                public string ERPSKUId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置预计收货数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expect_qty")]
                [System.Text.Json.Serialization.JsonPropertyName("expect_qty")]
                public int ExpectedQuantity { get; set; }

                /// <summary>
                /// 获取或设置条形码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_batch_assigned")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_batch_assigned")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool IsBatchAssigned { get; set; }

                /// <summary>
                /// 获取或设置序列号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sn_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sn_list")]
                public IList<string>? SerialNumberList { get; set; }

                /// <summary>
                /// 获取或设置币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string? Currency { get; set; }

                /// <summary>
                /// 获取或设置采购价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("purchase_price")]
                [System.Text.Json.Serialization.JsonPropertyName("purchase_price")]
                public int? PurchasePrice { get; set; }

                /// <summary>
                /// 获取或设置批次号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("batch_code")]
                [System.Text.Json.Serialization.JsonPropertyName("batch_code")]
                public string? BatchNumber { get; set; }

                /// <summary>
                /// 获取或设置生产时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_date")]
                [System.Text.Json.Serialization.JsonPropertyName("product_date")]
                public long? ProduceTimestamp { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_date")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_date")]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置扩展字段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extend")]
                [System.Text.Json.Serialization.JsonPropertyName("extend")]
                public string? Extra { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 获取或设置单据类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int OrderType { get; set; }

        /// <summary>
        /// 获取或设置出库仓库编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        [System.Text.Json.Serialization.JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运输方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_mode")]
        public int DeliveryMode { get; set; }

        /// <summary>
        /// 获取或设置入库单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_order_no")]
        public string BusinessOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_type")]
        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
        public int ActionType { get; set; }

        /// <summary>
        /// 获取或设置计划到达时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_arr_time")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_arr_time")]
        public long? PlanArrivalTimestamp { get; set; }

        /// <summary>
        /// 获取或设置最晚到达时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("late_arr_time")]
        [System.Text.Json.Serialization.JsonPropertyName("late_arr_time")]
        public long? LateArrivalTimestamp { get; set; }

        /// <summary>
        /// 获取或设置供应商编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_code")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_code")]
        public string? SupplierCode { get; set; }

        /// <summary>
        /// 获取或设置供应商名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_name")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_name")]
        public string? SupplierName { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置配送扩展字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_extend")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_extend")]
        public string? DeliveryExtra { get; set; }

        /// <summary>
        /// 获取或设置扩展字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend")]
        [System.Text.Json.Serialization.JsonPropertyName("extend")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_details")]
        [System.Text.Json.Serialization.JsonPropertyName("order_details")]
        public IList<Types.OrderLine>? OrderLineList { get; set; }
    }
}
