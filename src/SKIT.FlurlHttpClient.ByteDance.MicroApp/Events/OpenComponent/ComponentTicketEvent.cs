namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Events
{
    /// <summary>
    /// <para>表示 PUSH.Ticket 事件的数据。</para>
    /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/thirdparty/API/authorization/componentticket </para>
    /// </summary>
    public class ComponentTicketEvent : ByteDanceMicroAppEvent, ByteDanceMicroAppEvent.Serialization.IJsonSerializable, ByteDanceMicroAppEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置验证票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("Ticket")]
        [System.Xml.Serialization.XmlElement("Ticket")]
        public string Ticket { get; set; } = default!;
    }
}
