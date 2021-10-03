namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /sandbox/webhook/event/send 接口的响应。</para>
    /// </summary>
    public class SandboxWebhookEventSendResponse : TikTokResponse<SandboxWebhookEventSendResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }
    }
}
