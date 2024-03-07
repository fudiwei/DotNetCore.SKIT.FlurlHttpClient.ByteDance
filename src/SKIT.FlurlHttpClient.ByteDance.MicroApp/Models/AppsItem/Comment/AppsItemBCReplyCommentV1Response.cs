namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/item_bc/reply_comment/ 接口的响应。</para>
    /// </summary>
    public class AppsItemBCReplyCommentV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data : AppsItemReplyCommentV1Response.Types.Data
            {
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
