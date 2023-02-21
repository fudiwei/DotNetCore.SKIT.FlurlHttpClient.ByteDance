namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.UPDATE_AUTHORIZED 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/notify </para>
    /// </summary>
    public class ComponentUpdateAuthorizedEvent : ComponentAuthorizedEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, ByteDanceMicroAppOpenApiEvent.Serialization.IXmlSerializable
    {
    }
}
