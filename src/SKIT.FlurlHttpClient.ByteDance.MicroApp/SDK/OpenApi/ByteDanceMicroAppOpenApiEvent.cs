namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi
{
    /// <summary>
    /// 表示字节小程序服务商平台 API 消息推送事件的基类。
    /// </summary>
    public class ByteDanceMicroAppOpenApiEvent
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
        /// 获取或设置第三方平台 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TpAppId")]
        [System.Text.Json.Serialization.JsonPropertyName("TpAppId")]
        [System.Xml.Serialization.XmlElement("TpAppId", IsNullable = true)]
        public virtual string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置授权方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppId")]
        [System.Text.Json.Serialization.JsonPropertyName("AppId")]
        [System.Xml.Serialization.XmlElement("AppId", IsNullable = true)]
        public virtual string? AuthorizerAppId { get; set; }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Event")]
        [System.Text.Json.Serialization.JsonPropertyName("Event")]
        [System.Xml.Serialization.XmlElement("Event", IsNullable = true)]
        public virtual string? Event { get; set; }

        /// <summary>
        /// 获取或设置事件产生时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventTime")]
        [System.Text.Json.Serialization.JsonPropertyName("EventTime")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
        [System.Xml.Serialization.XmlElement("EventTime", IsNullable = true)]
        public virtual string? EventTimeString { get; set; }
    }
}
