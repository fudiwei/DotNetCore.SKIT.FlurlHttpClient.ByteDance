namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/capacity/apply_capacity 接口的请求。</para>
    /// </summary>
    public class AppsCapacityApplyCapacityV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置挂载能力标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capacity_key")]
        [System.Text.Json.Serialization.JsonPropertyName("capacity_key")]
        public string CapacityKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_reason")]
        public string ApplyReason { get; set; } = string.Empty;
    }
}
