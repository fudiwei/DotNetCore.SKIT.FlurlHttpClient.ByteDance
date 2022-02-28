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
        [System.Xml.Serialization.XmlElement("ToUserName")]
        public string ToUserName { get; set; } = default!;

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
        /// 获取或设置消息创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CreateTime")]
        [System.Text.Json.Serialization.JsonPropertyName("CreateTime")]
        [System.Xml.Serialization.XmlElement("CreateTime")]
        public long CreateTimestamp { get; set; }
    }
}
