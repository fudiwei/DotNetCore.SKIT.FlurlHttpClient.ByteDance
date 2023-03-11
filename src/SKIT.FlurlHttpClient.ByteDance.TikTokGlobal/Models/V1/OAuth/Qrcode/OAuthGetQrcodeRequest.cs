namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [GET] /v0/oauth/get_qrcode 接口的请求。</para>
    /// </summary>
    public class OAuthGetQrcodeRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置授权范围。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Scope { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CallbackUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义状态值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string State { get; set; } = string.Empty;
    }
}
