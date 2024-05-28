using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/create_pay_order/ 接口的请求。</para>
    /// </summary>
    public class TradeAuthDeveloperCreatePayOrderV1Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class FeeDetail
            {
                /// <summary>
                /// 获取或设置扣款项目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置扣款项目描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置扣款项目金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置扣款项目数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                public int Quantity { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置信用单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_order_id")]
        public string AuthOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者扣款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_pay_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_pay_order_no")]
        public string OutPayOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置费用明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fee_detail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fee_detail_list")]
        public IList<Types.FeeDetail> FeeDetailList { get; set; } = new List<Types.FeeDetail>();

        /// <summary>
        /// 获取或设置扣款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置回调通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }
    }
}
