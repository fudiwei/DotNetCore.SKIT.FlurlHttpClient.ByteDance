namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/check_qrcode/ 接口的响应。</para>
    /// </summary>
    public class OAuthCheckQrcodeResponse : TikTokV2Response
    {
        /// <summary>
        /// 获取或设置二维码状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置客户端票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("client_ticket")]
        public string ClientTicket { get; set; } = default!;

        /// <summary>
        /// 获取或设置重定向 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_uri")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// 获取或设置自定义状态值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }
    }
}
