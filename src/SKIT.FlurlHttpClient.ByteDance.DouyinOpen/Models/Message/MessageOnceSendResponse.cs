namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /message/once/send 接口的响应。</para>
    /// </summary>
    public class MessageOnceSendResponse : DouyinOpenResponse<MessageOnceSendResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
            }
        }
    }
}
