using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/pushOutboundFeedback 接口的请求。</para>
    /// </summary>
    public class YuncPushOutboundFeedbackRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Package
            {
                public static class Types
                {
                    public class Logistics
                    {
                        /// <summary>
                        /// 获取或设置物流公司编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                        public string? LogisticsCompanyCode { get; set; }

                        /// <summary>
                        /// 获取或设置物流单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("track_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("track_no")]
                        public string? LogisticsNumber { get; set; }

                        /// <summary>
                        /// 获取或设置运输方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_mode")]
                        public int? DeliveryMode { get; set; }
                    }

                    public class PackageItem
                    {
                        /// <summary>
                        /// 获取或设置货品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cargo_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("cargo_code")]
                        public int? CargoCode { get; set; }

                        /// <summary>
                        /// 获取或设置货品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cargo_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("cargo_name")]
                        public string? CargoName { get; set; }

                        /// <summary>
                        /// 获取或设置包装单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                        public string? Unit { get; set; }

                        /// <summary>
                        /// 获取或设置库存类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("inventory_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("inventory_type")]
                        public int? InventoryType { get; set; }

                        /// <summary>
                        /// 获取或设置数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int? Quantity { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置包裹号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_no")]
                [System.Text.Json.Serialization.JsonPropertyName("package_no")]
                public string? PackageNumber { get; set; }

                /// <summary>
                /// 获取或设置长度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("length")]
                [System.Text.Json.Serialization.JsonPropertyName("length")]
                public int? Length { get; set; }

                /// <summary>
                /// 获取或设置宽度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("width")]
                [System.Text.Json.Serialization.JsonPropertyName("width")]
                public int? Width { get; set; }

                /// <summary>
                /// 获取或设置高度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("height")]
                [System.Text.Json.Serialization.JsonPropertyName("height")]
                public int? Height { get; set; }

                /// <summary>
                /// 获取或设置体积（单位：立方厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("volume")]
                [System.Text.Json.Serialization.JsonPropertyName("volume")]
                public int? Volume { get; set; }

                /// <summary>
                /// 获取或设置重量（单位：克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                public int? Weight { get; set; }

                /// <summary>
                /// 获取或设置打包时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("packed_time")]
                [System.Text.Json.Serialization.JsonPropertyName("packed_time")]
                public long? PackTimestamp { get; set; }

                /// <summary>
                /// 获取或设置发货时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipped_time")]
                [System.Text.Json.Serialization.JsonPropertyName("shipped_time")]
                public long? ShipTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置物流信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics")]
                public Types.Logistics? Logistics { get; set; }

                /// <summary>
                /// 获取或设置货品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_items")]
                [System.Text.Json.Serialization.JsonPropertyName("package_items")]
                public IList<Types.PackageItem>? PackageItemList { get; set; }
            }

            public class OrderLine
            {
                /// <summary>
                /// 获取或设置出库单行号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("line_no")]
                [System.Text.Json.Serialization.JsonPropertyName("line_no")]
                public string? LineNumber { get; set; }

                /// <summary>
                /// 获取或设置货品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_code")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_code")]
                public int? CargoCode { get; set; }

                /// <summary>
                /// 获取或设置货品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_name")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_name")]
                public string? CargoName { get; set; }

                /// <summary>
                /// 获取或设置库存类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory_type")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory_type")]
                public int? InventoryType { get; set; }

                /// <summary>
                /// 获取或设置库存状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory_status")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory_status")]
                public int? InventoryStatus { get; set; }

                /// <summary>
                /// 获取或设置实际发货数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipped_qty")]
                [System.Text.Json.Serialization.JsonPropertyName("shipped_qty")]
                public int? ShipQuantity { get; set; }

                /// <summary>
                /// 获取或设置序列号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sn_list")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("sn_list")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
                public IList<string>? SerialNumberList { get; set; }

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
            }
        }

        /// <summary>
        /// 获取或设置单据类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int OrderType { get; set; }

        /// <summary>
        /// 获取或设置出库单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outbound_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("outbound_order_no")]
        public string? OutboundOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_type")]
        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public int? EventType { get; set; }

        /// <summary>
        /// 获取或设置事件描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_description")]
        [System.Text.Json.Serialization.JsonPropertyName("event_description")]
        public string? EventDescription { get; set; }

        /// <summary>
        /// 获取或设置仓库编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        [System.Text.Json.Serialization.JsonPropertyName("warehouse_code")]
        public string? WarehouseCode { get; set; }

        /// <summary>
        /// 获取或设置扩展字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend")]
        [System.Text.Json.Serialization.JsonPropertyName("extend")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置单据变化的流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("slip_no")]
        [System.Text.Json.Serialization.JsonPropertyName("slip_no")]
        public string? SlipNumber { get; set; }

        /// <summary>
        /// 获取或设置事件发生时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("occurrence_time")]
        [System.Text.Json.Serialization.JsonPropertyName("occurrence_time")]
        public long? OccurrenceTimestamp { get; set; }

        /// <summary>
        /// 获取或设置货主编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_code")]
        [System.Text.Json.Serialization.JsonPropertyName("owner_code")]
        public string? OwnerCode { get; set; }

        /// <summary>
        /// 获取或设置包裹列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("package_infos")]
        public List<Types.Package>? PackageList { get; set; }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_lines")]
        [System.Text.Json.Serialization.JsonPropertyName("order_lines")]
        public List<Types.OrderLine>? OrderLineList { get; set; }
    }
}
