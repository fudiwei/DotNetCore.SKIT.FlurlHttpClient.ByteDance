namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 im_send_msg 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/private-message/private-msg-webhook ]]> <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/private-message/private-msg-webhook ]]>
    /// </para>
    /// </summary>
    public class IMSendMessageEvent : DouyinOpenEvent<IMSendMessageEvent.Types.Content>
    {
        public static class Types
        {
            public class Content : IMReceiveMessageEvent.Types.Content
            {
            }
        }
    }
}
