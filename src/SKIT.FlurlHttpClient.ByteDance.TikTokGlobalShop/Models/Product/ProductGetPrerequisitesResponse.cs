namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/prerequisites 接口的响应。</para>
    /// </summary>
    public class ProductGetPrerequisitesResponse : TikTokShopResponse<ProductGetPrerequisitesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CheckResult
                    {
                        /// <summary>
                        /// 获取或设置检查项。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("check_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("check_item")]
                        public string CheckItem { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否失败。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_failed")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_failed")]
                        public bool IsFailed { get; set; }

                        /// <summary>
                        /// 获取或设置失败原因列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_reasons")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_reasons")]
                        public string[]? ReasonList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置检查结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("check_results")]
                [System.Text.Json.Serialization.JsonPropertyName("check_results")]
                public Types.CheckResult[] CheckResultList { get; set; } = default!;
            }
        }
    }
}
