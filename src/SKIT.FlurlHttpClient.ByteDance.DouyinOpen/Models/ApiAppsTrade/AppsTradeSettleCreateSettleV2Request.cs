using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/settle/create_settle 接口的请求。</para>
    /// </summary>
    public class AppsTradeSettleCreateSettleV2Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class SettleParameter
            {
                /// <summary>
                /// 获取或设置商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
                public string MerchantId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置分账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置开发者订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者分账单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_settle_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_settle_no")]
        public string OutSettleNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分账描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_desc")]
        public string SettleDescription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分账参数列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_params")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("settle_params")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public IList<Types.SettleParameter>? SettleParameterList { get; set; }

        /// <summary>
        /// 获取或设置商品单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
        public string? ItemOrderId { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置自定义字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cp_extra")]
        [System.Text.Json.Serialization.JsonPropertyName("cp_extra")]
        public string? Extra { get; set; }
    }
}
