namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/delivery 接口的响应。</para>
    /// </summary>
    public class FulfillmentUpdatePackageDeliveryStatusResponse : TikTokShopResponse<FulfillmentUpdatePackageDeliveryStatusResponse.Types.Data>
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
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string PackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置失败原因编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_code")]
                        public int FailReasonCode { get; set; }

                        /// <summary>
                        /// 获取或设置失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string? FailReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置处理失败的包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_packages")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_packages")]
                public Types.FailedPackage[] FailedPackageList { get; set; } = default!;
            }
        }
    }
}
