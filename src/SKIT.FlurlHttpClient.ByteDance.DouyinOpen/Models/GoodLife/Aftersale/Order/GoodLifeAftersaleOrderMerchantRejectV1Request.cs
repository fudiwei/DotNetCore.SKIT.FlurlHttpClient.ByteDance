using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/after_sale/order/merchant_reject 接口的请求。</para>
    /// </summary>
    public class GoodLifeAftersaleOrderMerchantRejectV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class RejectReason
            {
                /// <summary>
                /// 获取或设置拒单错误码列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason_code")]
                [System.Text.Json.Serialization.JsonPropertyName("reason_code")]
                public IList<int> ReasonCodeList { get; set; } = new List<int>();

                /// <summary>
                /// 获取或设置拒单描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string? Description { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置拒单原因信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public Types.RejectReason RejectReason { get; set; } = new Types.RejectReason();
    }
}
