namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /enterprise/leads/user/action/list 接口的响应。</para>
    /// </summary>
    public class EnterpriseLeadsUserActionListResponse : DouyinOpenResponse<EnterpriseLeadsUserActionListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Action
                    {
                        /// <summary>
                        /// 获取或设置意向用户的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
                        public string UserOpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
                        public int ActionType { get; set; }

                        /// <summary>
                        /// 获取或设置意向动作子类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_flag")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_flag")]
                        public int ActionFlag { get; set; }

                        /// <summary>
                        /// 获取或设置意向动作来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_source")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_source")]
                        public string ActionSource { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置互动记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Action[] ActionList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public long? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
