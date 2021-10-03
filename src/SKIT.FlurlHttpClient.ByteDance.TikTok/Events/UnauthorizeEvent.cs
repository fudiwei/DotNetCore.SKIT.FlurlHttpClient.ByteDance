namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Events
{
    /// <summary>
    /// <para>表示 unauthorize 事件的数据。</para>
    /// <para>REF: https://open.douyin.com/platform/doc/6850452581433608199 </para>
    /// </summary>
    public class UnauthorizeEvent : TikTokEvent<UnauthorizeEvent.Types.Content>
    {
        public static class Types
        {
            public class Content : AuthorizeEvent.Types.Content
            {
            }
        }
    }
}
