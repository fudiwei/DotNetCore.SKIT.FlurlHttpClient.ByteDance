using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/fulfilment/certificate/verify 接口的请求。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificateVerifyV1Request : TikTokRequest
    {
        public static class Types
        {
            public class CodeWithTime
            {
                /// <summary>
                /// 获取或设置三方码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string Code { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置核销时间戳（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_time")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_time")]
                public long VerifyTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置一次验券的标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_token")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_token")]
        public string VerifyToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置抖音门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string? POIId { get; set; }

        /// <summary>
        /// 获取或设置加密券码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encrypted_codes")]
        [System.Text.Json.Serialization.JsonPropertyName("encrypted_codes")]
        public IList<string>? EncryptedCodeList { get; set; }

        /// <summary>
        /// 获取或设置券码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("codes")]
        [System.Text.Json.Serialization.JsonPropertyName("codes")]
        public IList<string>? CodeList { get; set; }

        /// <summary>
        /// 获取或设置抖音订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置带有核销时间的三方码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_with_time_list")]
        [System.Text.Json.Serialization.JsonPropertyName("code_with_time_list")]
        public IList<Types.CodeWithTime>? CodeWithTimeList { get; set; }
    }
}
