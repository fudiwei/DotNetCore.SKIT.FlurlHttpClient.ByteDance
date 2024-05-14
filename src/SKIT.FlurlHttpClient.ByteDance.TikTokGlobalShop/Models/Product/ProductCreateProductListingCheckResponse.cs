namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/products/listing_check 接口的响应。</para>
    /// </summary>
    public class ProductCreateProductListingCheckResponse : TikTokShopResponse<ProductCreateProductListingCheckResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FailReason
                    {
                        /// <summary>
                        /// 获取或设置失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string Message { get; set; } = default!;
                    }

                    public class Warning : ProductCreateProductResponse.Types.Data.Types.Warning
                    {
                    }
                }

                /// <summary>
                /// 获取或设置检查结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("check_result")]
                [System.Text.Json.Serialization.JsonPropertyName("check_result")]
                public string CheckResult { get; set; } = default!;

                /// <summary>
                /// 获取或设置失败原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reasons")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reasons")]
                public Types.FailReason[]? FailReasonList { get; set; } = default!;

                /// <summary>
                /// 获取或设置警告信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warnings")]
                [System.Text.Json.Serialization.JsonPropertyName("warnings")]
                public Types.Warning? Warning { get; set; }
            }
        }
    }
}
