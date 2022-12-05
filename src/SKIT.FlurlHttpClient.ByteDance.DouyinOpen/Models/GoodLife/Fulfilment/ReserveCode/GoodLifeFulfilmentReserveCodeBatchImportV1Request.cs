using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/fulfilment/reserve_code/batch_import 接口的请求。</para>
    /// </summary>
    public class GoodLifeFulfilmentReserveCodeBatchImportV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public string? SKUId { get; set; }

        /// <summary>
        /// 获取或设置 SKU 外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("third_sku_id")]
        public string? OutSKUId { get; set; }

        /// <summary>
        /// 获取或设置未发放预置码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("codes")]
        [System.Text.Json.Serialization.JsonPropertyName("codes")]
        public IList<string> CodeList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置预置码过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expired_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expired_time")]
        public long? ExpireTimestamp { get; set; }
    }
}
