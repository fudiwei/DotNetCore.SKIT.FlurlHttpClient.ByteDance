namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 PUSH.Ticket 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/componentticket ]]>
    /// </para>
    /// </summary>
    public class ComponentPushTicketEvent : DouyinMicroAppOpenApiEvent
    {
        /// <summary>
        /// 获取或设置消息发送方账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FromUserName")]
        [System.Text.Json.Serialization.JsonPropertyName("FromUserName")]
        [System.Xml.Serialization.XmlElement("FromUserName")]
        public string FromUserName { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgType")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgType")]
        [System.Xml.Serialization.XmlElement("MsgType")]
        public string MessageType { get; set; } = default!;

        /// <summary>
        /// 获取或设置验证票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("Ticket")]
        [System.Xml.Serialization.XmlElement("Ticket")]
        public string Ticket { get; set; } = default!;

        /// <summary>
        /// 获取或设置票据生成时间字符串（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CreateTime")]
        [System.Text.Json.Serialization.JsonPropertyName("CreateTime")]
        [System.Xml.Serialization.XmlElement("CreateTime")]
        public string CreateTimeString { get; set; } = default!;
    }
}
