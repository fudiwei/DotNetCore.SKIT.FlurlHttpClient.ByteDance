namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/authorize/user_list/ 接口的响应。</para>
    /// </summary>
    public class IMAuthorizeUserListResponse : DouyinOpenResponse
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class AuthUser
                    {
                        public static class Types
                        {
                            public class Attribution
                            {
                                /// <summary>
                                /// 获取或设置主播 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("anchor_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("anchor_id")]
                                public string? AnchorId { get; set; }

                                /// <summary>
                                /// 获取或设置作者 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("author_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("author_id")]
                                public string? AuthorId { get; set; }

                                /// <summary>
                                /// 获取或设置群聊 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("conversation_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
                                public string? ConversationId { get; set; }

                                /// <summary>
                                /// 获取或设置群 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("group_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                                public string? GroupId { get; set; }

                                /// <summary>
                                /// 获取或设置消息 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("message_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("message_id")]
                                public string? MessageId { get; set; }

                                /// <summary>
                                /// 获取或设置直播间 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("room_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("room_id")]
                                public string? RoomId { get; set; }

                                /// <summary>
                                /// 获取或设置来源 UID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("from_att_uid")]
                                [System.Text.Json.Serialization.JsonPropertyName("from_att_uid")]
                                public string? FromUID { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置授权来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enter_from")]
                        [System.Text.Json.Serialization.JsonPropertyName("enter_from")]
                        public string EnterFrom { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置来源小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auth_user_source_app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("auth_user_source_app_id")]
                        public string? SourceAppId { get; set; }

                        /// <summary>
                        /// 获取或设置归因信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attribution")]
                        [System.Text.Json.Serialization.JsonPropertyName("attribution")]
                        public Types.Attribution? Attribution { get; set; }

                        /// <summary>
                        /// 获取或设置自定义参数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("data_im_extra")]
                        [System.Text.Json.Serialization.JsonPropertyName("data_im_extra")]
                        public string? DataIMExtra { get; set; }

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
                        /// 获取或设置加密的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("target_open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("target_open_id")]
                        public string? TargetOpenId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置授权用户列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_user_list")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_user_list")]
                public Types.AuthUser[] AuthUserList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否还有更多数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }

        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int ErrorNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string? LogId { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0;
        }
    }
}
