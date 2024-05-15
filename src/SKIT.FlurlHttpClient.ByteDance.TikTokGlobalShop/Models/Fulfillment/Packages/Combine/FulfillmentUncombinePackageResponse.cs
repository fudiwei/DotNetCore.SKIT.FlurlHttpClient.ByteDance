namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/packages/uncombine 接口的响应。</para>
    /// </summary>
    public class FulfillmentUncombinePackageResponse : TikTokShopResponse<FulfillmentUncombinePackageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Package : FulfillmentCombinePackageResponse.Types.Data.Types.Package
                    {
                    }
                }

                /// <summary>
                /// 获取或设置包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("packages")]
                [System.Text.Json.Serialization.JsonPropertyName("packages")]
                public Types.Package[] PackageList { get; set; } = default!;
            }
        }
    }
}
