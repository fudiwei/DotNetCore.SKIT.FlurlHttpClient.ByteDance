namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/bind_aweme_user 接口的请求。</para>
    /// </summary>
    public class AppsCapacityBindAwemeUserV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置绑定类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string BindType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_id")]
        public string AwemeId { get; set; } = string.Empty;
    }
}
