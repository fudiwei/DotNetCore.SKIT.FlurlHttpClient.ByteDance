namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/updatePostAmount 接口的请求。</para>
    /// </summary>
    public class OrderUpdatePostAmountRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置主订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pid")]
        [System.Text.Json.Serialization.JsonPropertyName("pid")]
        public string ParentOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运费金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("post_amount")]
        public int PostAmount { get; set; }
    }
}
