using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/exclusivePlan 接口的请求。</para>
    /// </summary>
    public class BuyinExclusivePlanRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Product : BuyinSimplePlanRequest.Types.Product
            {
            }
        }

        /// <summary>
        /// 获取或设置是否是创建。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_create")]
        [System.Text.Json.Serialization.JsonPropertyName("is_create")]
        public bool IsCreating { get; set; }

        /// <summary>
        /// 获取或设置开通状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("products")]
        [System.Text.Json.Serialization.JsonPropertyName("products")]
        public IList<Types.Product>? ProductList { get; set; }
    }
}
