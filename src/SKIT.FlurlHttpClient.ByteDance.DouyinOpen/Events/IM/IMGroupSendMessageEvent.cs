namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 im_group_send_msg 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/group-chat/group-msg/group.fans.webhook ]]> <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/group-chat/group-message/group.fans.webhook ]]>
    /// </para>
    /// </summary>
    public class IMGroupSendMessageEvent : DouyinOpenEvent<IMGroupSendMessageEvent.Types.Content>
    {
        public static class Types
        {
            public class Content : IMGroupReceiveMessageEvent.Types.Content
            {
            }
        }
    }
}
