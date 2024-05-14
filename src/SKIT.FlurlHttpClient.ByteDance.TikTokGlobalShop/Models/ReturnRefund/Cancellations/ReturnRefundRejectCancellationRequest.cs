using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/cancellations/{cancel_id}/reject 接口的请求。</para>
    /// </summary>
    public class ReturnRefundRejectCancellationRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Image
            {
                /// <summary>
                /// 获取或设置图片 URI。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_id")]
                [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                public string Uri { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图片 MIME 类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mime_type")]
                [System.Text.Json.Serialization.JsonPropertyName("mime_type")]
                public string? MimeType { get; set; }

                /// <summary>
                /// 获取或设置图片宽度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("width")]
                [System.Text.Json.Serialization.JsonPropertyName("width")]
                public int? Width { get; set; }

                /// <summary>
                /// 获取或设置图片高度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("height")]
                [System.Text.Json.Serialization.JsonPropertyName("height")]
                public int? Height { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置取消 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CancelId { get; set; } = string.Empty;

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
