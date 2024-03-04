namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /supply_chain/package_shipment_confirmation 接口的响应。</para>
    /// </summary>
    public class SupplyChainSyncPackageFulfillmentDataResponse : TikTokShopResponse<SupplyChainSyncPackageFulfillmentDataResponse.Types.Data>
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
                        /// 获取或设置失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                        public string? FailReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置导入失败的包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_package_list")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_package_list")]
                public Types.FailedPackage[] FailedPackageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置导入成功的包裹 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_package_list")]
                [System.Text.Json.Serialization.JsonPropertyName("success_package_list")]
                public string[] SucceededPackageList { get; set; } = default!;
            }
        }
    }
}
