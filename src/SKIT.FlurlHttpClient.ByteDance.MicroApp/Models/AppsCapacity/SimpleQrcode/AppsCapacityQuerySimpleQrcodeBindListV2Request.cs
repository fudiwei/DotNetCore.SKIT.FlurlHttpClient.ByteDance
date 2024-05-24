namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v2/capacity/query_simple_qr_bind_list/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityQuerySimpleQrcodeBindListV2Request : DouyinMicroAppRequest
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
    }
}
