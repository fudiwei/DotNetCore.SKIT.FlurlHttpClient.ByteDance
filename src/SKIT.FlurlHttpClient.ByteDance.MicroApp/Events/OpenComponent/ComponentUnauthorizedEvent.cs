namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Events
{
    /// <summary>
    /// <para>表示 EVENT.UNAUTHORIZED 事件的数据。</para>
    /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/send </para>
    /// </summary>
    public class ComponentUnauthorizedEvent : ByteDanceMicroAppEvent, ByteDanceMicroAppEvent.Serialization.IJsonSerializable, ByteDanceMicroAppEvent.Serialization.IXmlSerializable
    {
    }
}
