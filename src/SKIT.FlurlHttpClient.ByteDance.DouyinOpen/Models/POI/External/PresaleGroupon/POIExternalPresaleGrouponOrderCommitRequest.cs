namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/ext/presale_groupon/order/commit 接口的请求。</para>
    /// </summary>
    public class POIExternalPresaleGrouponOrderCommitRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置订单外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ext_id")]
        public string OrderExternalId { get; set; } = string.Empty;
    }
}
