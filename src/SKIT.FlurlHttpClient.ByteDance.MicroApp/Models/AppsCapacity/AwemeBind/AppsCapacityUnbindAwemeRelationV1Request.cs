namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/capacity/unbind_aweme_relation/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityUnbindAwemeRelationV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_id")]
        public string AwemeId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置绑定类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}
