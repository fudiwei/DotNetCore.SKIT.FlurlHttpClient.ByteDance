namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/packages/deliver 接口的响应。</para>
    /// </summary>
    public class FulfillmentBatchUpdatePackagesDeliveryStatusResponse : TikTokShopResponse<FulfillmentBatchUpdatePackagesDeliveryStatusResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Error
                    {
                        public static class Types
                        {
                            public class Detail
                            {
                                /// <summary>
                                /// 获取或设置包裹 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("package_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                                public string PackageId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public int Code { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string Message { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置详细信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail")]
                        public Types.Detail Detail { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置错误列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errors")]
                [System.Text.Json.Serialization.JsonPropertyName("errors")]
                public Types.Error[]? ErrorList { get; set; }
            }
        }
    }
}
