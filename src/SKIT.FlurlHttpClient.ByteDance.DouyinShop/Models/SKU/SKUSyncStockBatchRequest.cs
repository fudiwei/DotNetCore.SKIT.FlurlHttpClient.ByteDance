using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /sku/syncStockBatch 接口的请求。</para>
    /// </summary>
    public class SKUSyncStockBatchRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class SyncSKU
            {
                public static class Types
                {
                    public class Stock
                    {
                        /// <summary>
                        /// 获取或设置外部仓 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
                        public string OutWarehouseId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置仓库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_num")]
                        public int StockNumber { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置 SKU 类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_type")]
                public int SKUType { get; set; }

                /// <summary>
                /// 获取或设置库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_num")]
                public int? StockNumber { get; set; }

                /// <summary>
                /// 获取或设置阶梯库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("step_stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("step_stock_num")]
                public int? StepStockNumber { get; set; }

                /// <summary>
                /// 获取或设置区域库存列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_map")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_map")]
                public List<Types.Stock>? StockList { get; set; }

                /// <summary>
                /// 获取或设置供应商 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_id")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                public string? SupplierId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置幂等请求编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idempotent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("idempotent_id")]
        public string? IdempotentId { get; set; }

        /// <summary>
        /// 获取或设置幂等请求编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("incremental")]
        [System.Text.Json.Serialization.JsonPropertyName("incremental")]
        public bool IsIncremental { get; set; }

        /// <summary>
        /// 获取或设置需同步的 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_sync_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_sync_list")]
        public IList<Types.SyncSKU> SyncSKUList { get; set; } = new List<Types.SyncSKU>();
    }
}
