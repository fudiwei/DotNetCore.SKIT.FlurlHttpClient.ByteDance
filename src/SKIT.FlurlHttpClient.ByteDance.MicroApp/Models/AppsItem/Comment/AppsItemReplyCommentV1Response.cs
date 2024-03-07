namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/item/reply_comment/ 接口的响应。</para>
    /// </summary>
    public class AppsItemReplyCommentV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置评论 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("comment_id")]
                public string CommentId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
