namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/package/remove 接口的响应。</para>
    /// </summary>
    public class FulfillmentRemovePackageOrdersResponse : TikTokShopResponse<FulfillmentRemovePackageOrdersResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SucceededPackage
                    {
                        /// <summary>
                        /// 获取或设置包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string PackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
                        public string[] OrderIdList { get; set; } = default!;
                    }

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
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
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
                /// 获取或设置成功包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_list")]
                [System.Text.Json.Serialization.JsonPropertyName("package_list")]
                public Types.SucceededPackage[] SucceededPackageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置失败包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_package_list")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_package_list")]
                public Types.FailedPackage[] FailedPackageList { get; set; } = default!;
            }
        }
    }
}
