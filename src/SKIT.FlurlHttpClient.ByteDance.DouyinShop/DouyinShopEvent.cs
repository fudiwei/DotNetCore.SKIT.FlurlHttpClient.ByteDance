namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    /// <summary>
    /// 表示抖店开放平台 API 消息推送事件的基类。
    /// </summary>
    public class DouyinShopEvent
    {
        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msgId")]
        [System.Text.Json.Serialization.JsonPropertyName("msgId")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int Tag { get; set; }
    }

    /// <summary>
    /// 表示抖店开放平台 API 消息推送事件的泛型基类。
    /// </summary>
    public abstract class DouyinShopEvent<TData> : DouyinShopEvent
    {
        /// <summary>
        /// 获取或设置接口返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public TData Data { get; set; } = default!;
    }
}
