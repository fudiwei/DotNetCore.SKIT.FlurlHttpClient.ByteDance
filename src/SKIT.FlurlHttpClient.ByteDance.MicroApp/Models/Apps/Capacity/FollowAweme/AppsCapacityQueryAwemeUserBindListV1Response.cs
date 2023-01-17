namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_aweme_user_bind_list 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryAwemeUserBindListV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class User
                    {
                        /// <summary>
                        /// 获取或设置抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aweme_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("aweme_id")]
                        public string AwemeId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置抖音号昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                        public string UserName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置账号类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                        public int AccountType { get; set; }

                        /// <summary>
                        /// 获取或设置绑定状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bind_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
                        public int BindStatus { get; set; }

                        /// <summary>
                        /// 获取或设置解绑原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unbind_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("unbind_reason")]
                        public string? UnbindReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置绑定抖音号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.User[] UserList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
