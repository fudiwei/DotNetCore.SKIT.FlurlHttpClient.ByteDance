namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Events
{
    /// <summary>
    /// <para>表示 text 事件的数据。</para>
    /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/component/message-push-customer-service </para>
    /// </summary>
    public class TextMessageEvent : ByteDanceMicroAppEvent, ByteDanceMicroAppEvent.Serialization.IJsonSerializable, ByteDanceMicroAppEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Content")]
        [System.Text.Json.Serialization.JsonPropertyName("Content")]
        [System.Xml.Serialization.XmlElement("Content")]
        public string Content { get; set; } = default!;
    }
}
