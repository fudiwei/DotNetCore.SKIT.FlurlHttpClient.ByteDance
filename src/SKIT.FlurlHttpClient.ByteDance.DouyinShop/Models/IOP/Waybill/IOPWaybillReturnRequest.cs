namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/waybillReturn 接口的请求。</para>
    /// </summary>
    public class IOPWaybillReturnRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置代打店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public long DistributeShopId { get; set; }

        /// <summary>
        /// 获取或设置代打订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distr_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("distr_order_id")]
        public string DistributeOrderid { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置物流公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_code")]
        [System.Text.Json.Serialization.JsonPropertyName("company_code")]
        public string LogisticsCompanyCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置物流单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("track_no")]
        [System.Text.Json.Serialization.JsonPropertyName("track_no")]
        public string LogisticsNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否拒绝退款申请。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_refund_reject")]
        [System.Text.Json.Serialization.JsonPropertyName("is_refund_reject")]
        public bool? IsRefundRejected { get; set; }
    }
}
