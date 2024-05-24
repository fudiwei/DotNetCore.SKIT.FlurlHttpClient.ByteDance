using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/v1/settle 接口的请求。</para>
    /// </summary>
    public class AppsECPaySettleV1Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class SettleParameter
            {
                /// <summary>
                /// 获取或设置分账方商户号。
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
        /// 获取或设置小程序第三方平台应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户结算单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_settle_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_settle_no")]
        public string OutSettleNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结算描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_desc")]
        public string SettleDescription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分账方参数列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_params")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("settle_params")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public IList<Types.SettleParameter> SettleParameterList { get; set; } = new List<Types.SettleParameter>();

        /// <summary>
        /// 获取或设置签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public string? Signature { get; set; }

        /// <summary>
        /// 获取或设置自定义字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cp_extra")]
        [System.Text.Json.Serialization.JsonPropertyName("cp_extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }
    }
}
