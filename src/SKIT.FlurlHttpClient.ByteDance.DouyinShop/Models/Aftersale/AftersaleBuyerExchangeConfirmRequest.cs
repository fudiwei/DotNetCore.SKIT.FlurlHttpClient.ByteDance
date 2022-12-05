using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/buyerExchangeConfirm 接口的请求。</para>
    /// </summary>
    public class AftersaleBuyerExchangeConfirmRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
        public string AftersaleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否拒绝用户换货申请。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_reject")]
        [System.Text.Json.Serialization.JsonPropertyName("is_reject")]
        public bool IsReject { get; set; }

        /// <summary>
        /// 获取或设置换货动作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string? Action { get; set; }

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
        /// 获取或设置物流单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
        public string? LogisticsNumber { get; set; }

        /// <summary>
        /// 获取或设置物流公司编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_code")]
        [System.Text.Json.Serialization.JsonPropertyName("company_code")]
        public string? LogisticsCompanyCode { get; set; }
    }
}
