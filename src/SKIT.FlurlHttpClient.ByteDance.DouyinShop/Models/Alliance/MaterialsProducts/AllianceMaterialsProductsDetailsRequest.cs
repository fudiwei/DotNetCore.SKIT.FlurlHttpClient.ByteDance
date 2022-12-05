using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /alliance/materialsProductsDetails 接口的请求。</para>
    /// </summary>
    public class AllianceMaterialsProductsDetailsRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
        public IList<int>? ProductIdList { get; set; }
    }
}
