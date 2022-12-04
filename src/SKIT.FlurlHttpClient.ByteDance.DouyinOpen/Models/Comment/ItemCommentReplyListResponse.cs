namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /item/comment/reply/list 接口的响应。</para>
    /// </summary>
    public class ItemCommentReplyListResponse : DouyinOpenResponse<ItemCommentReplyListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : ItemCommentListResponse.Types.Data
            {
            }
        }
    }
}
