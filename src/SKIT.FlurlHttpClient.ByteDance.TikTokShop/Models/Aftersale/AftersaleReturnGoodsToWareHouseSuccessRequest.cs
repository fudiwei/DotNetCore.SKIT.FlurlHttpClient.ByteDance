namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/returnGoodsToWareHouseSuccess 接口的请求。</para>
    /// </summary>
    public class AftersaleReturnGoodsToWareHouseSuccessRequest : TikTokShopRequest
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

        /// <summary>
        /// 获取或设置用户退货物流单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tracking_no")]
        [System.Text.Json.Serialization.JsonPropertyName("tracking_no")]
        public string LogisticsNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置物流公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_company_code")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_company_code")]
        public string LogisticsCompanyCode { get; set; } = string.Empty;
    }
}
