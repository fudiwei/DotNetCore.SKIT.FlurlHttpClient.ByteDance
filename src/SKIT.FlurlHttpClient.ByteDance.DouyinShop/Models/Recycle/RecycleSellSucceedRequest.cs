namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /recycle/sellSucceed 接口的请求。</para>
    /// </summary>
    public class RecycleSellSucceedRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置线索单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clue_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("clue_order_id")]
        public string ClueOrderId { get; set; } = string.Empty;
    }
}
