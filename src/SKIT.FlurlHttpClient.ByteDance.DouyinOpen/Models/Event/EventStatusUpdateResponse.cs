namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /event/status/update 接口的响应。</para>
    /// </summary>
    public class EventStatusUpdateResponse : DouyinOpenResponse<EventStatusUpdateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
            }
        }
    }
}
