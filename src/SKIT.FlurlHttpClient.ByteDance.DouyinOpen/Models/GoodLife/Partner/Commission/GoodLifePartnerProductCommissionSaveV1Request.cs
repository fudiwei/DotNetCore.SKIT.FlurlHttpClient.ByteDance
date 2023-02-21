using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/partner/product_commission/save 接口的请求。</para>
    /// </summary>
    public class GoodLifePartnerProductCommissionSaveV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class ProductItem
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string ProductId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品分佣比例（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_ratio")]
                public int CommissionRatio { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品佣金配置列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_items")]
        [System.Text.Json.Serialization.JsonPropertyName("product_items")]
        public IList<Types.ProductItem> ProductItemList { get; set; } = new List<Types.ProductItem>();
    }
}
