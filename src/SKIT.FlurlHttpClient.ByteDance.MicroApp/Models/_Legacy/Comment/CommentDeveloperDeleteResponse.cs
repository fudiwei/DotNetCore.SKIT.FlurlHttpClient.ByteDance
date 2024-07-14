namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/comment/developer/delete 接口的响应。</para>
    /// </summary>
    public class CommentDeveloperDeleteResponse : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Reply
            {
                /// <summary>
                /// 获取或设置回复 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply_id")]
                [System.Text.Json.Serialization.JsonPropertyName("reply_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ReplyId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置回复内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reply")]
        [System.Text.Json.Serialization.JsonPropertyName("reply")]
        public Types.Reply Reply { get; set; } = default!;
    }
}
