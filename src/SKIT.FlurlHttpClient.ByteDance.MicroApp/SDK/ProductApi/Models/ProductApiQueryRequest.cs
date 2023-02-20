using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query 接口的请求。</para>
    /// </summary>
    public class ProductApiQueryRequest : ByteDanceMicroAppProductApiRequest
    {
        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
        public IList<long> ProductIdList { get; set; } = new List<long>();
    }
}
