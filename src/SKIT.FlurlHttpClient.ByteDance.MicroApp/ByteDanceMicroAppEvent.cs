namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 表示字节小程序 API 消息推送事件的基类。
    /// </summary>
    public class ByteDanceMicroAppEvent
    {
        public static class Serialization
        {
            [Newtonsoft.Json.JsonObject]
            public interface IJsonSerializable
            {
            }

            [System.Xml.Serialization.XmlRoot("xml")]
            public interface IXmlSerializable
            {
            }
        }

        /// <summary>
        /// 获取或设置消息接收方账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ToUserName")]
        [System.Text.Json.Serialization.JsonPropertyName("ToUserName")]
        [System.Xml.Serialization.XmlElement("ToUserName", IsNullable = true)]
        public string? ToUserName { get; set; }

        /// <summary>
        /// 获取或设置消息发送方账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("FromUserName")]
        [System.Text.Json.Serialization.JsonPropertyName("FromUserName")]
        [System.Xml.Serialization.XmlElement("FromUserName", IsNullable = true)]
        public string? FromUserName { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MsgType")]
        [System.Text.Json.Serialization.JsonPropertyName("MsgType")]
        [System.Xml.Serialization.XmlElement("MsgType", IsNullable = true)]
        public string? MessageType { get; set; }

        /// <summary>
        /// 获取或设置消息创建时间字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CreateTime")]
        [System.Text.Json.Serialization.JsonPropertyName("CreateTime")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
        [System.Xml.Serialization.XmlElement("CreateTime", IsNullable = true)]
        public string? CreateTimeString { get; set; }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Event")]
        [System.Text.Json.Serialization.JsonPropertyName("Event")]
        [System.Xml.Serialization.XmlElement("Event", IsNullable = true)]
        public string? Event { get; set; }

        /// <summary>
        /// 获取或设置第三方平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TpAppId")]
        [System.Text.Json.Serialization.JsonPropertyName("TpAppId")]
        [System.Xml.Serialization.XmlElement("TpAppId", IsNullable = true)]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置授权方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppId")]
        [System.Text.Json.Serialization.JsonPropertyName("AppId")]
        [System.Xml.Serialization.XmlElement("AppId", IsNullable = true)]
        public string? AuthorizerAppId { get; set; }

        /// <summary>
        /// 获取或设置事件产生时间字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventTime")]
        [System.Text.Json.Serialization.JsonPropertyName("EventTime")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
        [System.Xml.Serialization.XmlElement("EventTime", IsNullable = true)]
        public string? EventTimeString { get; set; }
    }
}
