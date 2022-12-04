namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /video/comment/list 接口的响应。</para>
    /// </summary>
    public class VideoCommentListResponse : DouyinOpenResponse<VideoCommentListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : ItemCommentListResponse.Types.Data
            {
            }
        }
    }
}
