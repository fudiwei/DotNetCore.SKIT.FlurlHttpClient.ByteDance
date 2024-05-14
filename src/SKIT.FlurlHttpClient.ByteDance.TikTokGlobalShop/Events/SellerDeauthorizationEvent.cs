namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Events
{
    /// <summary>
    /// <para>表示 SELLER_DEAUTHORIZATION 事件。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/65095746defece02be4d749d ]]>
    /// </para>
    /// </summary>
    public class SellerDeauthorizationEvent : TikTokShopEvent<SellerDeauthorizationEvent.Types.Data>
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
            }
        }
    }
}
