namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /products/activate 接口的响应。</para>
    /// </summary>
    public class ProductActivateProductsResponse : TikTokShopResponse<ProductActivateProductsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FailedReason
                    {
                        public static class Types
                        {
                            public class Error
                            {
                                /// <summary>
                                /// 获取或设置错误码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("status_code")]
                                public int ErrorCode { get; set; }

                                /// <summary>
                                /// 获取或设置错误信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                                public string? ErrorMessage { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public Types.Error[] ErrorList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置启用失败的商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_product_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_product_ids")]
                public string[]? FailedProductIdList { get; set; }

                /// <summary>
                /// 获取或设置失败原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_reasons")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_reasons")]
                public Types.FailedReason[]? FailedReasonList { get; set; } = default!;
            }
        }
    }
}
