namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/comment/top 接口的响应。</para>
    /// </summary>
    public class VideoCommentTopResponse : TikTokResponse<VideoCommentTopResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }
    }
}
