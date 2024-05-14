namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/cancellations/{cancel_id}/approve 接口的请求。</para>
    /// </summary>
    public class ReturnRefundApproveCancellationRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置取消 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CancelId { get; set; } = string.Empty;
    }
}
