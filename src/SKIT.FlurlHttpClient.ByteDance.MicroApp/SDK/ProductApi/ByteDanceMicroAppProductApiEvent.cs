namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi
{
    /// <summary>
    /// 表示字节小程序泛知识课程库 API 消息推送事件的基类。
    /// </summary>
    public class ByteDanceMicroAppProductApiEvent
    {
        /// <summary>
        /// 获取或设置通知类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notice_type")]
        [System.Text.Json.Serialization.JsonPropertyName("notice_type")]
        public int NoticeType { get; set; }

        /// <summary>
        /// 获取或设置确认通知方身份唯一的标志。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("developer_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("developer_flag")]
        public string DeveloperFlag { get; set; } = default!;

        /// <summary>
        /// 获取或设置自定义回调数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_data")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_data")]
        public string? CallbackData { get; set; }
    }
}
