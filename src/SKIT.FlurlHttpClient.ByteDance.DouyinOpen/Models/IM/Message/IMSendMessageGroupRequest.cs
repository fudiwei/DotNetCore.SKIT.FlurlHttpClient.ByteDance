namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/send/msg/group/ 接口的请求。</para>
    /// </summary>
    public class IMSendMessageGroupRequest : DouyinOpenRequest
    {
        public static class Types
        {
            public class Content
            {
                public static class Types
                {
                    public class MessageContentAsText : IMSendMessageRequest.Types.Content.Types.MessageContentAsText
                    {
                    }

                    public class MessageContentAsImage : IMSendMessageRequest.Types.Content.Types.MessageContentAsImage
                    {
                    }

                    public class MessageContentAsVideo : IMSendMessageRequest.Types.Content.Types.MessageContentAsVideo
                    {
                    }

                    public class MessageContentAsRetainConsultCard : IMSendMessageRequest.Types.Content.Types.MessageContentAsRetainConsultCard
                    {
                    }

                    public class MessageContentAsAppletCard : IMSendMessageRequest.Types.Content.Types.MessageContentAsAppletCard
                    {
                    }
                }

                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_type")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
                public int MessageType { get; set; }

                /// <summary>
                /// 获取或设置文字内容消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public Types.MessageContentAsText? MessageContentAsText { get; set; }

                /// <summary>
                /// 获取或设置图片内容消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public Types.MessageContentAsImage? MessageContentAsImage { get; set; }

                /// <summary>
                /// 获取或设置视频内容消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video")]
                [System.Text.Json.Serialization.JsonPropertyName("video")]
                public Types.MessageContentAsVideo? MessageContentAsVideo { get; set; }

                /// <summary>
                /// 获取或设置留资卡片内容消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("retain_consult_card")]
                [System.Text.Json.Serialization.JsonPropertyName("retain_consult_card")]
                public Types.MessageContentAsRetainConsultCard? MessageContentAsRetainConsultCard { get; set; }

                /// <summary>
                /// 获取或设置小程序引导卡片内容消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applet_card")]
                [System.Text.Json.Serialization.JsonPropertyName("applet_card")]
                public Types.MessageContentAsAppletCard? MessageContentAsAppletCard { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群 ID。与字段 <see cref="GroupToken"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// 获取或设置群 Token。与字段 <see cref="GroupId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_token")]
        [System.Text.Json.Serialization.JsonPropertyName("group_token")]
        public string? GroupToken { get; set; }

        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public Types.Content? Content { get; set; }
    }
}
