namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /message/once/send 接口的响应。</para>
    /// </summary>
    public class MessageOnceSendResponse : TikTokResponse<MessageOnceSendResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }
    }
}
