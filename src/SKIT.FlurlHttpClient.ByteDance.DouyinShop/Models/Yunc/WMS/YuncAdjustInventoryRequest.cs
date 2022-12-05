using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/adjustInventory 接口的请求。</para>
    /// </summary>
    public class YuncAdjustInventoryRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Detail
            {
                public static class Types
                {
                    public class Adjustment
                    {
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
                        /// 获取或设置调整类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adjust_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("adjust_type")]
                        public int AdjustType { get; set; }

                        /// <summary>
                        /// 获取或设置调整数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("batch_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("batch_no")]
                        public int AdjustQuantity { get; set; }

                        /// <summary>
                        /// 获取或设置批次号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("batch_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("batch_no")]
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
                /// 获取或设置行号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("line_no")]
                [System.Text.Json.Serialization.JsonPropertyName("line_no")]
                public string LineNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置货品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_code")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_code")]
                public string CargoCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置 ERP SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("erp_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("erp_sku_id")]
                public string? ERPSKUId { get; set; }

                /// <summary>
                /// 获取或设置店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                public int? ShopId { get; set; }

                /// <summary>
                /// 获取或设置货主编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner_code")]
                [System.Text.Json.Serialization.JsonPropertyName("owner_code")]
                public string OwnerCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置货主名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner_name")]
                [System.Text.Json.Serialization.JsonPropertyName("owner_name")]
                public string? OwnerName { get; set; }

                /// <summary>
                /// 获取或设置调整列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("adjust_list")]
                [System.Text.Json.Serialization.JsonPropertyName("adjust_list")]
                public IList<Types.Adjustment> AdjustmentList { get; set; } = new List<Types.Adjustment>();
            }
        }

        /// <summary>
        /// 获取或设置单据类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int OrderType { get; set; }

        /// <summary>
        /// 获取或设置	库存调整单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inventory_adjust_no")]
        [System.Text.Json.Serialization.JsonPropertyName("inventory_adjust_no")]
        public string InventoryAdjustNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置仓库编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        [System.Text.Json.Serialization.JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置调整原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adjust_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("adjust_reason")]
        public int AdjustReasonType { get; set; }

        /// <summary>
        /// 获取或设置调整时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adjust_time")]
        [System.Text.Json.Serialization.JsonPropertyName("adjust_time")]
        public long AdjustTimestamp { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置调整明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("details")]
        [System.Text.Json.Serialization.JsonPropertyName("details")]
        public List<Types.Detail>? DetailList { get; set; }
    }
}
