using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /supply_chain/{version}/packages/sync 接口的请求。</para>
    /// </summary>
    public class SupplyChainSyncPackagesRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Package
            {
                public static class Types
                {
                    public class Dimension
                    {
                        /// <summary>
                        /// 获取或设置长度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("length")]
                        [System.Text.Json.Serialization.JsonPropertyName("length")]
                        public int? Length { get; set; }

                        /// <summary>
                        /// 获取或设置宽度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int? Width { get; set; }

                        /// <summary>
                        /// 获取或设置高度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int? Height { get; set; }

                        /// <summary>
                        /// 获取或设置单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                        public string? Unit { get; set; }
                    }

                    public class Weight
                    {
                        /// <summary>
                        /// 获取或设置重量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public int? Value { get; set; }

                        /// <summary>
                        /// 获取或设置单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                        public string? Unit { get; set; }
                    }

                    public class SKU
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string SKUId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int Quantity { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string PackageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();

                /// <summary>
                /// 获取或设置 WMS 订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wms_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("wms_order_id")]
                public string WMSOrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置供应商仓库编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("provider_warehouse_code")]
                [System.Text.Json.Serialization.JsonPropertyName("provider_warehouse_code")]
                public string? ProviderWarehouseCode { get; set; }

                /// <summary>
                /// 获取或设置发货城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_origin_city")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_origin_city")]
                public string? ShippingOriginCity { get; set; }

                /// <summary>
                /// 获取或设置时区。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_zone")]
                [System.Text.Json.Serialization.JsonPropertyName("time_zone")]
                public string TimeZone { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置发货时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ship_time_millis")]
                [System.Text.Json.Serialization.JsonPropertyName("ship_time_millis")]
                public long ShipTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置创建时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time_millis")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time_millis")]
                public long CreateTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置交接时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("handover_time_millis")]
                [System.Text.Json.Serialization.JsonPropertyName("handover_time_millis")]
                public long HandoverTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置运输服务商 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_provider_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_id")]
                public string ShippingProviderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置运输服务商名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_provider_name")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_name")]
                public string ShippingProviderName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tracking_number")]
                [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
                public string TrackingNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置尺寸信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dimension")]
                [System.Text.Json.Serialization.JsonPropertyName("dimension")]
                public Types.Dimension? Dimension { get; set; }

                /// <summary>
                /// 获取或设置重量信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                public Types.Weight? Weight { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置仓库供应商 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_provider_id")]
        [System.Text.Json.Serialization.JsonPropertyName("warehouse_provider_id")]
        public string WarehouseProviderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置包裹列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("packages")]
        [System.Text.Json.Serialization.JsonPropertyName("packages")]
        public IList<Types.Package> PackageList { get; set; } = new List<Types.Package>();
    }
}
