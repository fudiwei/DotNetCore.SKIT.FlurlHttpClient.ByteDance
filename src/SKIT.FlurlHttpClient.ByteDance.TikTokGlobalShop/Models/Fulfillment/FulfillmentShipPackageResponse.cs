namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/rts 接口的响应。</para>
    /// </summary>
    public class FulfillmentShipPackageResponse : TikTokShopResponse<FulfillmentShipPackageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FailedPackage
                    {
                        /// <summary>
                        /// 获取或设置包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string PackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置失败原因编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_code")]
                        public int FailReasonCode { get; set; }

                        /// <summary>
                        /// 获取或设置失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                        public string? FailReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置失败包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_packages")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_packages")]
                public Types.FailedPackage[] FailedPackageList { get; set; } = default!;
            }
        }
    }
}
