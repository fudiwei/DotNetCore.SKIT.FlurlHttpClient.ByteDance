using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/query_item_order_info 接口的请求。</para>
    /// </summary>
    public class AppsTradeQueryItemOrderInfoV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("item_order_id_list")]
        public IList<string>? ItemOrderIdList { get; set; }
    }
}
