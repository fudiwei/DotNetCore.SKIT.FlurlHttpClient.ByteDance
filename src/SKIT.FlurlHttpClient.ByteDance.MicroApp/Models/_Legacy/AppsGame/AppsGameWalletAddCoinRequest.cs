namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/game/wallet/add_coin 接口的请求。</para>
    /// </summary>
    public class AppsGameWalletAddCoinRequest : AppsGameWalletRequestBase
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string BillNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置赠送游戏币的数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_counts")]
        [System.Text.Json.Serialization.JsonPropertyName("present_counts")]
        public int PresentAmount { get; set; }
    }
}
