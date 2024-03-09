namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    public abstract class AppsGameWalletRequestBase : DouyinMicroAppRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开始时间字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zone_id")]
        [System.Text.Json.Serialization.JsonPropertyName("zone_id")]
        public string ZoneId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置平台。
        /// <para>默认值："android"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pf")]
        [System.Text.Json.Serialization.JsonPropertyName("pf")]
        public string Platform { get; set; } = "android";

        /// <summary>
        /// 获取或设置时间戳。如果不指定将由系统自动生成
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ts")]
        [System.Text.Json.Serialization.JsonPropertyName("ts")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 获取或设置用户 IP 地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("user_ip")]
        public string? UserIp { get; set; }

        /// <summary>
        /// 获取或设置签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mp_sig")]
        [System.Text.Json.Serialization.JsonPropertyName("mp_sig")]
        public string? Signature { get; set; }
    }
}
