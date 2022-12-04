namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/search/comment/reply 接口的响应。</para>
    /// </summary>
    public class VideoSearchCommentReplyResponse : DouyinOpenResponse<VideoSearchCommentReplyResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : VideoCommentReplyResponse.Types.Data
            {
            }
        }
    }
}
