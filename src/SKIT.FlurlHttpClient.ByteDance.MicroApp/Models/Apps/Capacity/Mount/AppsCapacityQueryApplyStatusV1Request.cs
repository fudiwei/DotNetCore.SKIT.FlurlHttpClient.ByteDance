namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_apply_status 接口的请求。</para>
    /// </summary>
    public class AppsCapacityQueryApplyStatusV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置挂载能力标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CapacityKey { get; set; } = string.Empty;
    }
}
