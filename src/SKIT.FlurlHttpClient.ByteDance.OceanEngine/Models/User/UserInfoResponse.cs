namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/user/info 接口的响应。</para>
    /// </summary>
    public class UserInfoResponse : OceanEngineResponse<UserInfoResponse.Types.User[]>
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置用户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long UserId { get; set; }

                /// <summary>
                /// 获取或设置邮箱（已脱敏处理）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string Email { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("display_name")]
                [System.Text.Json.Serialization.JsonPropertyName("display_name")]
                public string DisplayName { get; set; } = default!;
            }
        }
    }
}
