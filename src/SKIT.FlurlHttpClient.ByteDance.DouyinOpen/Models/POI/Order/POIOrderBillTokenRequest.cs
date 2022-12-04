namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/order/bill/token 接口的请求。</para>
    /// </summary>
    public class POIOrderBillTokenRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置账单日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BillDateString { get; set; } = string.Empty;
    }
}
