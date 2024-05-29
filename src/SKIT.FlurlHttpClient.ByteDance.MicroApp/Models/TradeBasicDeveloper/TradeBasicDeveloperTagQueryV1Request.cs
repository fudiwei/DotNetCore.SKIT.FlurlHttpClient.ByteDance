namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/tag_query/ 接口的请求。</para>
    /// </summary>
    public class TradeBasicDeveloperTagQueryV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置商品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_type")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_type")]
        public int? GoodsType { get; set; }
    }
}
