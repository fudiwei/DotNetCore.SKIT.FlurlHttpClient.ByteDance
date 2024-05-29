using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/delivery_verify 接口的请求。</para>
    /// </summary>
    public class AppsTradeDeliveryVerifyV2Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class Certificate
            {
                /// <summary>
                /// 获取或设置加密券码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypted_code")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypted_code")]
                public string EncryptedCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_id")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                public string CertificateId { get; set; } = string.Empty;
            }

            public class POIInfo
            {
                /// <summary>
                /// 获取或设置店铺名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_name")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
                public string? ShopName { get; set; }

                /// <summary>
                /// 获取或设置核销门店的外部店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_valid_shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_valid_shop_id")]
                public string? ExternalValidShopId { get; set; }

                /// <summary>
                /// 获取或设置核销门店对应的抖音 POI ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_poi_id_str")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_poi_id_str")]
                public string? ValidPOIId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置验券 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_token")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_token")]
        public string VerifyToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificates")]
        [System.Text.Json.Serialization.JsonPropertyName("certificates")]
        public IList<Types.Certificate> CertificateList { get; set; } = new List<Types.Certificate>();

        /// <summary>
        /// 获取或设置商铺 POI 信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_info")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("poi_info")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public Types.POIInfo? POIInfo { get; set; }
    }
}
