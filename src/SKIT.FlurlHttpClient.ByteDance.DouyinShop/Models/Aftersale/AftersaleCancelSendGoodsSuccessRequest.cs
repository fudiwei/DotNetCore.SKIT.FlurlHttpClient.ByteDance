namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/CancelSendGoodsSuccess 接口的请求。</para>
    /// </summary>
    public class AftersaleCancelSendGoodsSuccessRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        public string AftersaleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op_time")]
        [System.Text.Json.Serialization.JsonPropertyName("op_time")]
        public long OperateTimestamp { get; set; }
    }
}
