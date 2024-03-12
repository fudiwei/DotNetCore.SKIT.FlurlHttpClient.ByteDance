using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/group/setting/set/ 接口的请求。</para>
    /// </summary>
    public class IMGroupSettingSetRequest : DouyinOpenRequest
    {
        public static class Types
        {
            public class Message
            {
                public static class Types
                {
                    public class MessageContentAsText : IMSendMessageRequest.Types.Content.Types.MessageContentAsText
                    {
                    }

                    public class MessageContentAsAppletCard : IMSendMessageRequest.Types.Content.Types.MessageContentAsAppletCard
                    {
                    }

                    public class MessageContentAsAppletCoupon : IMSendMessageRequest.Types.Content.Types.MessageContentAsAppletCoupon
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
                /// 获取或设置小程序引导卡片内容消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applet_card")]
                [System.Text.Json.Serialization.JsonPropertyName("applet_card")]
                public Types.MessageContentAsAppletCard? MessageContentAsAppletCard { get; set; }

                /// <summary>
                /// 获取或设置小程序券内容消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applet_coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("applet_coupon")]
                public Types.MessageContentAsAppletCoupon? MessageContentAsAppletCoupon { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置管理配置类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_setting_type")]
        [System.Text.Json.Serialization.JsonPropertyName("group_setting_type")]
        public int SettingType { get; set; }

        /// <summary>
        /// 获取或设置消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_list")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_list")]
        public IList<Types.Message>? MessageList { get; set; }
    }
}
