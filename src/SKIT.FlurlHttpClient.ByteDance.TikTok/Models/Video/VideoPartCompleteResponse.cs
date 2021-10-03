namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/part/complete 接口的响应。</para>
    /// </summary>
    public class VideoPartCompleteResponse : TikTokResponse<VideoPartCompleteResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : VideoUploadResponse.Types.Data
            {
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
