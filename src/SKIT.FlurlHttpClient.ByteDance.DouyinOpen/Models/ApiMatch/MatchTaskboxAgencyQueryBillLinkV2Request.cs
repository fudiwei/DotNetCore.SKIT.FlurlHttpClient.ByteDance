namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v2/taskbox/agency_query_bill_link/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskboxAgencyQueryBillLinkV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置计费日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_date")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_date")]
        public string BillDateString { get; set; } = string.Empty;
    }
}
