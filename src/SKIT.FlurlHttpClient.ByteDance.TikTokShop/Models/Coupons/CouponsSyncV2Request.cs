using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /coupons/syncV2 接口的请求。</para>
    /// </summary>
    public class CouponsSyncV2Request : TikTokShopRequest
    {
        public static class Types
        {
            public class Cert
            {
                /// <summary>
                /// 获取或设置外部卡券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_cert_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_cert_id")]
                public string? OutCertId { get; set; }

                /// <summary>
                /// 获取或设置卡券券码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_no")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_no")]
                public string CertNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置卡密。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_key")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_key")]
                public string? CertKey { get; set; }

                /// <summary>
                /// 获取或设置发券时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grant_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("grant_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset GrantTime { get; set; }

                /// <summary>
                /// 获取或设置可延期次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_extend_valid_count")]
                [System.Text.Json.Serialization.JsonPropertyName("can_extend_valid_count")]
                public int? CanExtendValidCount { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int? Status { get; set; }

                /// <summary>
                /// 获取或设置有效开始时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_start")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("valid_start")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                public DateTimeOffset? ValidStartTime { get; set; }

                /// <summary>
                /// 获取或设置有效结束时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_end")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("valid_end")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                public DateTimeOffset? ValidEndTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public long? SKUId { get; set; }

        /// <summary>
        /// 获取或设置卡券信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_list")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_list")]
        public IList<Types.Cert> CertList { get; set; } = new List<Types.Cert>();
    }
}
