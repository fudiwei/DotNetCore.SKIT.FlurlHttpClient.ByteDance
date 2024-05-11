namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/products/activate 接口的响应。</para>
    /// </summary>
    public class ProductActivateProductsResponse : TikTokShopResponse<ProductActivateProductsResponse.Types.Data>
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
                                public static class Types
                                {
                                    public class ExtraError
                                    {
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
                                [Newtonsoft.Json.JsonProperty("extra_errors")]
                                [System.Text.Json.Serialization.JsonPropertyName("extra_errors")]
                                public Types.ExtraError[] ExtraErrorList { get; set; } = default!;
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
