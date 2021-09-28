namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /antispam/userLogin 接口的请求。</para>
    /// </summary>
    public class AntiSpamUserLoginRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置用户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("uid_type")]
                [System.Text.Json.Serialization.JsonPropertyName("uid_type")]
                public int? UserType { get; set; }

                /// <summary>
                /// 获取或设置用户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_id")]
                [System.Text.Json.Serialization.JsonPropertyName("user_id")]
                public long? UserId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user")]
        [System.Text.Json.Serialization.JsonPropertyName("user")]
        public Types.User? User { get; set; }

        /// <summary>
        /// 获取或设置可变参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("params")]
        [System.Text.Json.Serialization.JsonPropertyName("params")]
        public string? JsonParams { get; set; }

        /// <summary>
        /// 获取或设置事件时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_time")]
        [System.Text.Json.Serialization.JsonPropertyName("event_time")]
        public long? EventTimestamp { get; set; }
    }
}
