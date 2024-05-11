namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/categories/{category_id}/global_attributes 接口的响应。</para>
    /// </summary>
    public class ProductGetGlobalCategoryAttributesResponse : TikTokShopResponse<ProductGetGlobalCategoryAttributesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Attribute : ProductGetCategoryAttributesResponse.Types.Data.Types.Attribute
                    {
                    }
                }

                /// <summary>
                /// 获取或设置属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attributes")]
                [System.Text.Json.Serialization.JsonPropertyName("attributes")]
                public Types.Attribute[] AttributeList { get; set; } = default!;
            }
        }
    }
}
