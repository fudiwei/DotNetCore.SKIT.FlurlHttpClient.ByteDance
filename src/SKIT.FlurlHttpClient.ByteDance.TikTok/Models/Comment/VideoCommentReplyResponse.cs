namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/comment/reply 接口的响应。</para>
    /// </summary>
    public class VideoCommentReplyResponse : TikTokResponse<VideoCommentReplyResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : ItemCommentReplyResponse.Types.Data
            {
            }
        }
    }
}
