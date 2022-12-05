using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /opptyProduct/apply 接口的请求。</para>
    /// </summary>
    public class OpportunityProductApplyRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置线索 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clue_id")]
        [System.Text.Json.Serialization.JsonPropertyName("clue_id")]
        public int ClueId { get; set; }

        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
        public IList<long> ProductIdList { get; set; } = new List<long>();

        /// <summary>
        /// 获取或设置机会品来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("origin")]
        [System.Text.Json.Serialization.JsonPropertyName("origin")]
        public string Origin { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置机会品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}
