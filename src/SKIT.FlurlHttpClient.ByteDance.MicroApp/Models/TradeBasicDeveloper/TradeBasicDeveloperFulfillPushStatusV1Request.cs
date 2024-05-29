using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/fulfill_push_status 接口的请求。</para>
    /// </summary>
    public class TradeBasicDeveloperFulfillPushStatusV1Request : DouyinMicroAppRequest
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
        public IList<string> ItemOrderIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置目标状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_status")]
        [System.Text.Json.Serialization.JsonPropertyName("to_status")]
        public string ToStatus { get; set; } = string.Empty;
    }
}
