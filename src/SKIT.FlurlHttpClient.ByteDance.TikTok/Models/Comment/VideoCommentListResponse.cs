namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /video/comment/list 接口的响应。</para>
    /// </summary>
    public class VideoCommentListResponse : TikTokResponse<VideoCommentListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : ItemCommentListResponse.Types.Data
            {
            }
        }
    }
}
