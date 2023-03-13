namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /finance/order/settlements 接口的请求。</para>
    /// </summary>
    public class FinanceGetOrderSettlementListRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OrderId { get; set; } = string.Empty;
    }
}
