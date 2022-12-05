namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/waybillCancel 接口的请求。</para>
    /// </summary>
    public class IOPWaybillCancelRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置代打店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public long DistributeShopId { get; set; }

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
    }
}
