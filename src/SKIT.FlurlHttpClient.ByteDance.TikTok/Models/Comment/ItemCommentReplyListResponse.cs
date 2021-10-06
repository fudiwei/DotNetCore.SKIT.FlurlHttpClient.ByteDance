namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /item/comment/reply/list 接口的响应。</para>
    /// </summary>
    public class ItemCommentReplyListResponse : TikTokResponse<ItemCommentReplyListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : ItemCommentListResponse.Types.Data
            {
            }
        }
    }
}
