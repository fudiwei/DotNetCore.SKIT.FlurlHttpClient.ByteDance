namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/capacity/query_bind_doudian_account 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryBindDoudianAccountV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置抖店账号绑定状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doudian_account_status")]
                [System.Text.Json.Serialization.JsonPropertyName("doudian_account_status")]
                public int AccountStatus { get; set; }

                /// <summary>
                /// 获取或设置抖店账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account")]
                [System.Text.Json.Serialization.JsonPropertyName("account")]
                public string? Account { get; set; }

                /// <summary>
                /// 获取或设置抖店用户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                public string? Username { get; set; }

                /// <summary>
                /// 获取或设置抖店主体。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject")]
                [System.Text.Json.Serialization.JsonPropertyName("subject")]
                public string? Subject { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
