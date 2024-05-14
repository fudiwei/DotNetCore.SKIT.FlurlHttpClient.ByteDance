namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Events
{
    /// <summary>
    /// <para>表示 UPCOMING_AUTHORIZATION_EXPIRATION 事件。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/6509579c0fcef602bf11312c ]]>
    /// </para>
    /// </summary>
    public class UpcomingAuthorizationExpirationEvent : TikTokShopEvent<UpcomingAuthorizationExpirationEvent.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置通知消息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message")]
                [System.Text.Json.Serialization.JsonPropertyName("message")]
                public string Message { get; set; } = default!;

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expiration_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expiration_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ExpireTimestamp { get; set; }
            }
        }
    }
}
