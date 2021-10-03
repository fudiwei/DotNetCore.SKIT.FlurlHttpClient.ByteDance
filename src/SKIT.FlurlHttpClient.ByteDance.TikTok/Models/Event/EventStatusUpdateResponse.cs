namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /event/status/update 接口的响应。</para>
    /// </summary>
    public class EventStatusUpdateResponse : TikTokResponse<EventStatusUpdateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }
    }
}
