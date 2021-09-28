using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /coupons/verifyV2 接口的请求。</para>
    /// </summary>
    public class CouponsVerifyV2Request : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置卡券券码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_no")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_no")]
        public string CertNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置核销时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("verify_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? VerifyTime { get; set; }

        /// <summary>
        /// 获取或设置幂等请求编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_no")]
        public string? BatchNumber { get; set; }

        /// <summary>
        /// 获取或设置当次核销的次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_count")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_count")]
        public int? VerifyCount { get; set; }
    }
}
