namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 life_member_leave 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/member/member.join </para>
    /// </summary>
    public class LifeMemberLeaveEvent : DouyinOpenEvent<LifeMemberLeaveEvent.Types.Content>
    {
        public static class Types
        {
            public class Content : LifeMemberJoinEvent.Types.Content
            {
            }
        }
    }
}
