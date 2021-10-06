namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/search/comment/reply 接口的响应。</para>
    /// </summary>
    public class VideoSearchCommentReplyResponse : TikTokResponse<VideoSearchCommentReplyResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : VideoCommentReplyResponse.Types.Data
            {
            }
        }
    }
}
