using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/send/msg/ 接口的请求。</para>
    /// </summary>
    public class IMSendMessageRequest : DouyinOpenRequest
    {
        public static class Types
        {
            public class Content
            {
                public static class Types
                {
                    public class MessageContentAsText
                    {
                        /// <summary>
                        /// 获取或设置文字内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string Text { get; set; } = string.Empty;
                    }

                    public class MessageContentAsImage
                    {
                        /// <summary>
                        /// 获取或设置素材 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string MediaId { get; set; } = string.Empty;
                    }

                    public class MessageContentAsVideo
                    {
                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                        public string ItemId { get; set; } = string.Empty;
                    }

                    public class MessageContentAsRetainConsultCard
                    {
                        /// <summary>
                        /// 获取或设置卡片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                        public string CardId { get; set; } = string.Empty;
                    }

                    public class MessageContentAsGroupInvitation
                    {
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
                    }

                    public class MessageContentAsAppletCard
                    {
                        /// <summary>
                        /// 获取或设置模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_template_id")]
                        public string CardTemplateId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        public string MicroAppId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序页面路径。与字段 <see cref="MicroAppSchemaUrl"/> 二选一。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string? MicroAppPagePath { get; set; }

                        /// <summary>
                        /// 获取或设置小程序页面参数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("query")]
                        [System.Text.Json.Serialization.JsonPropertyName("query")]
                        public string? MicroAppPageQuery { get; set; }

                        /// <summary>
                        /// 获取或设置小程序 Schema URL。与字段 <see cref="MicroAppPagePath"/> 二选一。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("schema")]
                        [System.Text.Json.Serialization.JsonPropertyName("schema")]
                        public string? MicroAppSchemaUrl { get; set; }
                    }

                    public class MessageContentAsAppletCoupon
                    {
                        /// <summary>
                        /// 获取或设置活动 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                        public long ActivityId { get; set; }

                        /// <summary>
                        /// 获取或设置券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
                        public long CouponMetaId { get; set; }
                    }

                    public class MessageContentAsAuthPrivateMessageCard
                    {
                        public static class Types
                        {
                            public class MicroAppInfo
                            {
                                /// <summary>
                                /// 获取或设置小程序 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                                public string AppId { get; set; } = string.Empty;
                            }

                            public class UserInfo
                            {
                                /// <summary>
                                /// 获取或设置 B 端 ClientKey。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                                public string ClientKey { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置 B 端用户的 OpenId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("open_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                                public string OpenId { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置小程序信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_info")]
                        public Types.MicroAppInfo MicroAppInfo { get; set; } = new Types.MicroAppInfo();

                        /// <summary>
                        /// 获取或设置用户信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("to_user_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("to_user_info")]
                        public Types.UserInfo UserInfo { get; set; } = new Types.UserInfo();
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
                /// 获取或设置群聊邀请内容消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_invitation")]
                [System.Text.Json.Serialization.JsonPropertyName("group_invitation")]
                public Types.MessageContentAsGroupInvitation? MessageContentAsGroupInvitation { get; set; }

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

                /// <summary>
                /// 获取或设置主动私信授权卡片内容消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_private_message_card")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_private_message_card")]
                public Types.MessageContentAsAuthPrivateMessageCard? MessageContentAsAuthPrivateMessageCard { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string? ClientMessageId { get; set; }

        /// <summary>
        /// 获取或设置会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conversation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 获取或设置消息的接收方 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("to_user_id")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public Types.Content? Content { get; set; }

        /// <summary>
        /// 获取或设置消息内容列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_list")]
        [System.Text.Json.Serialization.JsonPropertyName("content_list")]
        public IList<Types.Content>? ContentList { get; set; }

        /// <summary>
        /// 获取或设置私信场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string Scene { get; set; } = string.Empty;
    }
}
