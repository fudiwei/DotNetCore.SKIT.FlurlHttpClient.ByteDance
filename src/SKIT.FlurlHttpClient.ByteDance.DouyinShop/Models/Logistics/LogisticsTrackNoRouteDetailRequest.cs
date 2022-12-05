namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/trackNoRouteDetail 接口的请求。</para>
    /// </summary>
    public class LogisticsTrackNoRouteDetailRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置快递公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
        public string LogisticsCompanyCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("track_no")]
        [System.Text.Json.Serialization.JsonPropertyName("track_no")]
        public string LogisticsNumber { get; set; } = string.Empty;
    }
}
