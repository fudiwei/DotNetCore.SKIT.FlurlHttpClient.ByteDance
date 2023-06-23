namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.APP_NAME_RESET_NOTIFICATION 事件的数据。</para>
    /// <para>REF: https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/modify-name </para>
    /// </summary>
    public class AppNameResetEvent : ByteDanceMicroAppOpenApiEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, ByteDanceMicroAppOpenApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置名称重置通知。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppNameResetNotification")]
        [System.Text.Json.Serialization.JsonPropertyName("AppNameResetNotification")]
        [System.Xml.Serialization.XmlElement("AppNameResetNotification")]
        public string AppNameResetNotification { get; set; } = default!;
    }
}
