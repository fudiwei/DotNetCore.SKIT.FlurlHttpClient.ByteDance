namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Events
{
    /// <summary>
    /// <para>表示 unauthorize 事件的数据。</para>
    /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/develop/webhooks/event-list </para>
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
