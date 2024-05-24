namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/capacity/query_ma_sub_service/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityQueryMicroAppSubServiceV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? ApprovalState { get; set; }
    }
}
