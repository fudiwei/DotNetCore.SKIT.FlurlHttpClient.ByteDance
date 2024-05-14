using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/returns/{return_id}/reject 接口的请求。</para>
    /// </summary>
    public class ReturnRefundRejectReturnRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Image : ReturnRefundRejectCancellationRequest.Types.Image
            {
            }
        }

        /// <summary>
        /// 获取或设置退货 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ReturnId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置决定。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("decision")]
        [System.Text.Json.Serialization.JsonPropertyName("decision")]
        public string Decision { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置评论内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment")]
        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 获取或设置图片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images")]
        [System.Text.Json.Serialization.JsonPropertyName("images")]
        public IList<Types.Image>? ImageList { get; set; }
    }
}
