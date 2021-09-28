using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/submitEvidence 接口的请求。</para>
    /// </summary>
    public class AftersaleSubmitEvidenceRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        public string AftersaleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置凭证图片 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("evidence")]
        [System.Text.Json.Serialization.JsonPropertyName("evidence")]
        public IList<string> EvidenceUrlList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment")]
        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Remark { get; set; }
    }
}
