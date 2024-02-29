namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/get_qrcode/ 接口的响应。</para>
    /// </summary>
    public class OAuthGetQrcodeResponse : TikTokV2Response
    {
        /// <summary>
        /// 获取或设置二维码链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scan_qrcode_url")]
        [System.Text.Json.Serialization.JsonPropertyName("scan_qrcode_url")]
        public string ScanQrcodeUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置二维码令牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = default!;
    }
}
