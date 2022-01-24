namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Events
{
    /// <summary>
    /// <para>表示 image 事件的数据。</para>
    /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/component/message-push-customer-service </para>
    /// </summary>
    public class ImageMessageEvent : ByteDanceMicroAppEvent, ByteDanceMicroAppEvent.Serialization.IJsonSerializable, ByteDanceMicroAppEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PicUrl")]
        [System.Text.Json.Serialization.JsonPropertyName("PicUrl")]
        [System.Xml.Serialization.XmlElement("PicUrl")]
        public string PictureUrl { get; set; } = default!;
    }
}
