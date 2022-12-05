using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/buyerExchange 接口的请求。</para>
    /// </summary>
    public class AftersaleBuyerExchangeRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        public string AftersaleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否拒绝用户换货申请。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_reject")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_reject")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualBooleanConverter))]
        public bool IsReject { get; set; }

        /// <summary>
        /// 获取或设置 SMS ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sms_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sms_id")]
        public string SMSId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment")]
        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 获取或设置图片凭证 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("evidence")]
        [System.Text.Json.Serialization.JsonPropertyName("evidence")]
        public IList<string>? EvidenceUrlList { get; set; }

        /// <summary>
        /// 获取或设置收货地址 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("address_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? AddressId { get; set; }

        /// <summary>
        /// 获取或设置卖家售后备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }
    }
}
