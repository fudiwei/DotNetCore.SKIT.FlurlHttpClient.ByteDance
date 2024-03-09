namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.CREATE_SUBSCRIBE_NOTIFICATION_TEMPLATE_RESULT 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/subscribe-notification-template ]]>
    /// </para>
    /// </summary>
    public class CreateSubscribeNotificationTemplateResultEvent : DouyinMicroAppOpenApiEvent
    {
        public static class Types
        {
            public class EventContent
            {
                /// <summary>
                /// 获取或设置模板标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                [System.Xml.Serialization.XmlElement("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置关键字列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keyword_list")]
                [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
                [System.Xml.Serialization.XmlElement("keyword_list", Type = typeof(string))]
                public string[] KeywordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审核拒绝原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_reason_list")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_reason_list")]
                [System.Xml.Serialization.XmlElement("reject_reason_list", Type = typeof(string), IsNullable = true)]
                public string[]? RejectReasonList { get; set; }
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
