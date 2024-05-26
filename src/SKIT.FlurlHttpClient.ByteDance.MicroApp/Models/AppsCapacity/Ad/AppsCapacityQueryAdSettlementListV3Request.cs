namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v3/capacity/query_ad_settlement_list/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityQueryAdSettlementListV3Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置结算周期字符串（格式：yyyy-MM）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PeriodString { get; set; }

        /// <summary>
        /// 获取或设置结算状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Status { get; set; }
    }
}
