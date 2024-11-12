namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fbt/{version}/merchants/onboarded_regions 接口的响应。</para>
    /// </summary>
    public class FBTGetMerchantOnboardedRegionsResponse : TikTokShopResponse<FBTGetMerchantOnboardedRegionsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class OnboardedRegion
                    {
                        /// <summary>
                        /// 获取或设置国家或地区编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("region_code")]
                        public string RegionCode { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置已入驻国家或地区列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("onboarded_regions")]
                [System.Text.Json.Serialization.JsonPropertyName("onboarded_regions")]
                public Types.OnboardedRegion[] OnboardedRegionList { get; set; } = default!;
            }
        }
    }
}
