using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /supply_chain/package_shipment_confirmation 接口的请求。</para>
    /// </summary>
    public class SupplyChainSyncPackageFulfillmentDataRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Package
            {
                public static class Types
                {
                    public class SKU
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
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
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                public string PackageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
                public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();

                /// <summary>
                /// 获取或设置 WMS 订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wms_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("wms_order_no")]
                public string WMSOrderNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置供应商仓库编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("provider_warehouse_code")]
                [System.Text.Json.Serialization.JsonPropertyName("provider_warehouse_code")]
                public string? ProviderWarehouseCode { get; set; }

                /// <summary>
                /// 获取或设置发货城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipped_city")]
                [System.Text.Json.Serialization.JsonPropertyName("shipped_city")]
                public string? ShippedCity { get; set; }

                /// <summary>
                /// 获取或设置时区。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_zone")]
                [System.Text.Json.Serialization.JsonPropertyName("time_zone")]
                public string TimeZone { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置发货时间字符串（格式：yyyy/MM/dd HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipped_time")]
                [System.Text.Json.Serialization.JsonPropertyName("shipped_time")]
                public string ShippedTimeString { get; set; } = string.Empty;

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
                /// 获取或设置配送方式名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_option_name")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_option_name")]
                public string? DeliveryOptionName { get; set; }

                /// <summary>
                /// 获取或设置长度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("length")]
                [System.Text.Json.Serialization.JsonPropertyName("length")]
                public int? Length { get; set; }

                /// <summary>
                /// 获取或设置宽度单位。
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
                /// 获取或设置重量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                public int? Weight { get; set; }

                /// <summary>
                /// 获取或设置尺寸单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("length_unit")]
                [System.Text.Json.Serialization.JsonPropertyName("length_unit")]
                public int? DimensionUnit { get; set; }

                /// <summary>
                /// 获取或设置重量单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight_unit")]
                [System.Text.Json.Serialization.JsonPropertyName("weight_unit")]
                public int? WeightUnit { get; set; }

                /// <summary>
                /// 获取或设置创建时间字符串（格式：yyyy/MM/dd HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public string CreateTimeString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置交接时间字符串（格式：yyyy/MM/dd HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hand_over_time")]
                [System.Text.Json.Serialization.JsonPropertyName("hand_over_time")]
                public string HandOverTimeString { get; set; } = string.Empty;
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
        [Newtonsoft.Json.JsonProperty("package")]
        [System.Text.Json.Serialization.JsonPropertyName("package")]
        public IList<Types.Package> PackageList { get; set; } = new List<Types.Package>();
    }
}
