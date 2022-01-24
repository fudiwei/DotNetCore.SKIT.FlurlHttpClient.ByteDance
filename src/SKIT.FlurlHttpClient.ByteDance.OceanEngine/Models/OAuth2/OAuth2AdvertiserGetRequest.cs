/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /oauth2/advertiser/get 接口的请求。</para>
    /// </summary>
    public class OAuth2AdvertiserGetRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="OceanEngineClient"/> 时的 <see cref="OceanEngineClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public long? AppId { get; set; }

        /// <summary>
        /// 获取或设置应用密钥。如果不指定将使用构造 <see cref="OceanEngineClient"/> 时的 <see cref="OceanEngineClientOptions.AppSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secret")]
        [System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? AppSecret { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }
    }
}
