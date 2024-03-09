namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Events
{
    /// <summary>
    /// <para>表示 text 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/component/message-push-customer-service ]]>
    /// </para>
    /// </summary>
    public class TextMessageEvent : DouyinMicroAppEvent
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
