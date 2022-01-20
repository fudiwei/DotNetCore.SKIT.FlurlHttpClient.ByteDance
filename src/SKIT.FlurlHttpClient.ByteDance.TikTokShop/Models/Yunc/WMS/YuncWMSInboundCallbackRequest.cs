using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/wmsInboundCallback 接口的请求。</para>
    /// </summary>
    public class YuncWMSInboundCallbackRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Detail
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
                [Newtonsoft.Json.JsonProperty("inbound_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("inbound_order_no")]
                public string InboundOrderId { get; set; } = string.Empty;

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
                /// 获取或设置累计实收数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_qty")]
                [System.Text.Json.Serialization.JsonPropertyName("total_qty")]
                public int TotalQuantity { get; set; }

                /// <summary>
                /// 获取或设置本次实收数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("received_qty")]
                [System.Text.Json.Serialization.JsonPropertyName("received_qty")]
                public int ReceivedQuantity { get; set; }

                /// <summary>
                /// 获取或设置序列号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sn_list")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("sn_list")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
                public IList<string>? SerialNumberList { get; set; }

                /// <summary>
                /// 获取或设置货主编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner_code")]
                [System.Text.Json.Serialization.JsonPropertyName("owner_code")]
                public string OwnerCode { get; set; } = string.Empty;

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

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置单据类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public string OrderType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置入库单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inbound_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("inbound_order_no")]
        public string InboundOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置仓库编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        [System.Text.Json.Serialization.JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作人。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        [System.Text.Json.Serialization.JsonPropertyName("operator")]
        public string Operator { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_time")]
        [System.Text.Json.Serialization.JsonPropertyName("operate_time")]
        public long OperateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reamrk")]
        [System.Text.Json.Serialization.JsonPropertyName("reamrk")]
        public string? Reamrk { get; set; }

        /// <summary>
        /// 获取或设置明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("details")]
        [System.Text.Json.Serialization.JsonPropertyName("details")]
        public List<Types.Detail>? DetailList { get; set; }
    }
}
