namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/order/delete 接口的请求。</para>
    /// </summary>
    public class AppsOrderDeleteRequest : DouyinMicroAppRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置宿主名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appname")]
        [System.Text.Json.Serialization.JsonPropertyName("appname")]
        public string AppName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;
    }
}
