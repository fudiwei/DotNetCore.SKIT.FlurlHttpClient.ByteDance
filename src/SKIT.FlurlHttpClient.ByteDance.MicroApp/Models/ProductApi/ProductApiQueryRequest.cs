using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/api/query 接口的请求。</para>
    /// </summary>
    public class ProductApiQueryRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
        public IList<long> ProductIdList { get; set; } = new List<long>();
    }
}
