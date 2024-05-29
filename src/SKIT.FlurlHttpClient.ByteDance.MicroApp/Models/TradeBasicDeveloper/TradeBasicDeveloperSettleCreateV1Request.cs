using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/settle_create/ 接口的请求。</para>
    /// </summary>
    public class TradeBasicDeveloperSettleCreateV1Request : DouyinMicroAppRequest
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
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

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
        /// 获取或设置自定义字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext")]
        [System.Text.Json.Serialization.JsonPropertyName("ext")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }
    }
}
