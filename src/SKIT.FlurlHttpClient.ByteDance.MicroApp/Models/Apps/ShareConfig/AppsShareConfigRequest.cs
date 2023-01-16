namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/share_config 接口的请求。</para>
    /// </summary>
    public class AppsShareConfigRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置用户的抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uniq_id")]
        [System.Text.Json.Serialization.JsonPropertyName("uniq_id")]
        public string UserUniqueId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int ActionType { get; set; }
    }
}
