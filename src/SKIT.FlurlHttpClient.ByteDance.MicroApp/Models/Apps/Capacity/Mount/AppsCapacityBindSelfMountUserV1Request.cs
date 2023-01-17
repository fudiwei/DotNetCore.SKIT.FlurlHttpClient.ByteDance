namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/bind_self_mount_user 接口的请求。</para>
    /// </summary>
    public class AppsCapacityBindSelfMountUserV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置挂载能力标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capacity_key")]
        [System.Text.Json.Serialization.JsonPropertyName("capacity_key")]
        public string CapacityKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_id")]
        public string AwemeId { get; set; } = string.Empty;
    }
}
