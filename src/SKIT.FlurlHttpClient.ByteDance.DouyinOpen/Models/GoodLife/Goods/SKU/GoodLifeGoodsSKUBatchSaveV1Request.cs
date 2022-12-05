using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/sku/batch_save 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsSKUBatchSaveV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class SKU : GoodLifeGoodsProductSaveV1Request.Types.SKU
            {
                public static new class Types
                {
                    public class Stock : GoodLifeGoodsProductSaveV1Request.Types.SKU.Types.Stock
                    {
                    }
                }

                /// <summary>
                /// 获取或设置库存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock")]
                [System.Text.Json.Serialization.JsonPropertyName("stock")]
                public new Types.Stock Stock { get; set; } = new Types.Stock();
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。与字段 <see cref="OutProductId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string? ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品外部 ID。与字段 <see cref="ProductId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_id")]
        public string? OutProductId { get; set; }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
        public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();
    }
}
