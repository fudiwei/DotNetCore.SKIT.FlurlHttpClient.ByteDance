namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /seller/manage_global_product/check 接口的响应。</para>
    /// </summary>
    public class SellerCheckGlobalProductModeResponse : TikTokShopResponse<SellerCheckGlobalProductModeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置是否可使用全球商品。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_use_global_product")]
                [System.Text.Json.Serialization.JsonPropertyName("can_use_global_product")]
                public bool CanUseGlobalProduct { get; set; }
            }
        }
    }
}
