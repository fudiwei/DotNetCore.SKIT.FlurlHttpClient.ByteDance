namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /antispam/orderQuery 接口的请求。</para>
    /// </summary>
    public class AntiSpamOrderQueryRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class User : AntiSpamUserLoginRequest.Types.User
            {
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
