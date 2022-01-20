using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/replyService 接口的请求。</para>
    /// </summary>
    public class OrderReplyServiceRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置服务请求 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 获取或设置商家答复内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reply")]
        [System.Text.Json.Serialization.JsonPropertyName("reply")]
        public string ReplyDetail { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回复凭证 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("evidence")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("evidence")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithPipeSplitConverter))]
        public IList<string>? EvidenceUrlList { get; set; }
    }
}
