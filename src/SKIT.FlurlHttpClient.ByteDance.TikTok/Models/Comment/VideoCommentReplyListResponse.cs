namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /video/comment/reply/list 接口的响应。</para>
    /// </summary>
    public class VideoCommentReplyListResponse : TikTokResponse<VideoCommentReplyListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : ItemCommentReplyListResponse.Types.Data
            {
            }
        }
    }
}
