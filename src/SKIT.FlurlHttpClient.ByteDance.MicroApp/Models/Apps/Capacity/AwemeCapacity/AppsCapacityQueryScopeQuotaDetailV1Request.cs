namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_scope_quota_detail 接口的请求。</para>
    /// </summary>
    public class AppsCapacityQueryScopeQuotaDetailV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置权限 Key。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PermissionKey { get; set; } = string.Empty;
    }
}
