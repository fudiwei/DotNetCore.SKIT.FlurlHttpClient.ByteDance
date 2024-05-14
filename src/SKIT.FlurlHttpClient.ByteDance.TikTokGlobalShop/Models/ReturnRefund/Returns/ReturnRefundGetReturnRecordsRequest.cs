namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /return_refund/{version}/returns/{return_id}/records 接口的请求。</para>
    /// </summary>
    public class ReturnRefundGetReturnRecordsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置退货 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ReturnId { get; set; } = string.Empty;
    }
}
