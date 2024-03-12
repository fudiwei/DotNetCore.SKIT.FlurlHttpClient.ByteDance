namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 im_enter_direct_msg 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/private-message/enter-direct-msg-webhook ]]> <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/private-message/enter-direct-msg-webhook ]]>
    /// </para>
    /// </summary>
    public class IMEnterDirectMessageEvent : DouyinOpenEvent<IMEnterDirectMessageEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                public static class Types
                {
                    public class UserInfo
                    {
                        /// <summary>
                        /// 获取或设置用户唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nick_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avatar")]
                        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                        public string AvatarUrl { get; set; } = default!;
                    }

                    public class AdInfo
                    {
                        /// <summary>
                        /// 获取或设置广告计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                        public long AdId { get; set; }

                        /// <summary>
                        /// 获取或设置广告计划名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_name")]
                        public string AdName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adv_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("adv_id")]
                        public long AdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置广告主名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adv_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("adv_name")]
                        public string AdvertiserName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创意 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("creative_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("creative_id")]
                        public long? CreativeId { get; set; }

                        /// <summary>
                        /// 获取或设置广告 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
                        public long? PromotionId { get; set; }

                        /// <summary>
                        /// 获取或设置素材标题 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("material_title_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("material_title_id")]
                        public long? MaterialTitleId { get; set; }

                        /// <summary>
                        /// 获取或设置素材图片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("material_image_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("material_image_id")]
                        public long? MaterialImageId { get; set; }

                        /// <summary>
                        /// 获取或设置素材视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("material_video_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("material_video_id")]
                        public long? MaterialVideoId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("server_message_id")]
                [System.Text.Json.Serialization.JsonPropertyName("server_message_id")]
                public string ServerMessageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置会话 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("conversation_short_id")]
                [System.Text.Json.Serialization.JsonPropertyName("conversation_short_id")]
                public string ConversationShortId { get; set; } = default!;

                /// <summary>
                /// 获取或设置会话类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("conversation_type")]
                [System.Text.Json.Serialization.JsonPropertyName("conversation_type")]
                public int ConversationType { get; set; }

                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("objectId")]
                [System.Text.Json.Serialization.JsonPropertyName("objectId")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// 获取或设置场景类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_type")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_type")]
                public int SceneType { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string? PagePath { get; set; }

                /// <summary>
                /// 获取或设置页面参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string? PageQuery { get; set; }

                /// <summary>
                /// 获取或设置自定义参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data-im-extra")]
                [System.Text.Json.Serialization.JsonPropertyName("data-im-extra")]
                public string? DataIMExtra { get; set; }

                /// <summary>
                /// 获取或设置用户列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("user_infos")]
                public Types.UserInfo[]? UserList { get; set; }

                /// <summary>
                /// 获取或设置广告信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_info")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("ad_info")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
                public Types.AdInfo? AdInfo { get; set; }
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public override Types.Content EventContent { get; set; } = default!;
    }
}
