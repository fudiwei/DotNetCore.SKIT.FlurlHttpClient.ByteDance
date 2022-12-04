using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/ext/presale_groupon/order/cancel 接口的请求。</para>
    /// </summary>
    public class POIExternalPresaleGrouponOrderCancelRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置预约券券码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_list")]
        [System.Text.Json.Serialization.JsonPropertyName("code_list")]
        public IList<string>? CodeList { get; set; }

        /// <summary>
        /// 获取或设置外部订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ext_id")]
        public string OrderExternalId { get; set; } = string.Empty;
    }
}
