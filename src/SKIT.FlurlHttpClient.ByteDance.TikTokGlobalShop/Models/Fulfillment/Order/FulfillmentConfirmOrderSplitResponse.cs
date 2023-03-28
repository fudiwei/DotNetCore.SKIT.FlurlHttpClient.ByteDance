namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/order_split/confirm 接口的响应。</para>
    /// </summary>
    public class FulfillmentConfirmOrderSplitResponse : TikTokShopResponse<FulfillmentConfirmOrderSplitResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置预拆包 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_split_pkg_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_split_pkg_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string PreSplitPackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置确认结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("confirm_result")]
                        [System.Text.Json.Serialization.JsonPropertyName("confirm_result")]
                        public bool ConfirmResult { get; set; }
                    }

                    public class SucceededSplitPackage
                    {
                        /// <summary>
                        /// 获取或设置预拆包 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_split_pkg_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_split_pkg_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string PreSplitPackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string PackgeId { get; set; } = default!;
                    }

                    public class FailedSplitPackage
                    {
                        /// <summary>
                        /// 获取或设置预拆包 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_split_pkg_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_split_pkg_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string PreSplitPackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                        public string? FailReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("confirm_result_list")]
                [System.Text.Json.Serialization.JsonPropertyName("confirm_result_list")]
                public Types.Result[] ResultList { get; set; } = default!;

                /// <summary>
                /// 获取或设置处理成功的预拆包列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_list")]
                [System.Text.Json.Serialization.JsonPropertyName("success_list")]
                public Types.SucceededSplitPackage[] SucceededSplitPackageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置处理失败的预拆包列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
                public Types.FailedSplitPackage[] FailedSplitPackageList { get; set; } = default!;
            }
        }
    }
}
