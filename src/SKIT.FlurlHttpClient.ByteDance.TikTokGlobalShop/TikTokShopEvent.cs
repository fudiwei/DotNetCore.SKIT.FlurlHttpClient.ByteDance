namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    /// <summary>
    /// 表示 TikTok Shop API Webhook 事件的基类。
    /// </summary>
    [Newtonsoft.Json.JsonObject]
    public class TikTokShopEvent : ICommonWebhookEvent
    {
        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public virtual int Type { get; set; }

        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        public virtual string ShopId { get; set; } = default!;

        /// <summary>
        /// 获取或设置事件时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public virtual long Timestamp { get; set; }

        /// <summary>
        /// 获取或设置通知 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tts_notification_id")]
        [System.Text.Json.Serialization.JsonPropertyName("tts_notification_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        public virtual string? NotificationId { get; set; }
    }

    /// <summary>
    /// 表示 TikTok Shop API Webhook 事件的泛型基类。
    /// </summary>
    [Newtonsoft.Json.JsonObject]
    public class TikTokShopEvent<TData> : TikTokShopEvent, ICommonWebhookEvent
    {
        /// <summary>
        /// 获取或设置事件携带数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public TData Data { get; set; } = default!;
    }
}
