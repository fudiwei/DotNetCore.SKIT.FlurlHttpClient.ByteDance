namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/order/delete 接口的响应。</para>
    /// </summary>
    public class AppsOrderDeleteResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_code")]
        [System.Text.Json.Serialization.JsonPropertyName("err_code")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置 JSON 格式的生活服务关联业务推送结果与业务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body")]
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? DataJson { get; set; }
    }
}
