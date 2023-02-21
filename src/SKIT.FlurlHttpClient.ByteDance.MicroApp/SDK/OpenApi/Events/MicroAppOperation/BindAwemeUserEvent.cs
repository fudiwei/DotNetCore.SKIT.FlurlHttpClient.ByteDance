namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.BIND_AWEME_USER 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/follow-aweme </para>
    /// </summary>
    public class BindAwemeUserEvent : ByteDanceMicroAppOpenApiEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, ByteDanceMicroAppOpenApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class EventContent
            {
                /// <summary>
                /// 获取或设置绑定类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                [System.Xml.Serialization.XmlElement("type")]
                public string BindType { get; set; } = default!;

                /// <summary>
                /// 获取或设置抖音号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aweme_id")]
                [System.Text.Json.Serialization.JsonPropertyName("aweme_id")]
                [System.Xml.Serialization.XmlElement("aweme_id")]
                public string AwemeId { get; set; } = default!;

                /// <summary>
                /// 获取或设置抖音号昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                [System.Xml.Serialization.XmlElement("user_name")]
                public string UserName { get; set; } = default!;

                /// <summary>
                /// 获取或设置绑定状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_status")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
                [System.Xml.Serialization.XmlElement("bind_status")]
                public int BindStatus { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventContent")]
        [System.Text.Json.Serialization.JsonPropertyName("EventContent")]
        [System.Xml.Serialization.XmlElement("EventContent")]
        public Types.EventContent EventContent { get; set; } = default!;
    }
}
