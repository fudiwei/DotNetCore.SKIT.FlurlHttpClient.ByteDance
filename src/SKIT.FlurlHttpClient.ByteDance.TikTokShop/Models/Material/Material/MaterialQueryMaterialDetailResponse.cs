namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/queryMaterialDetail 接口的响应。</para>
    /// </summary>
    public class MaterialQueryMaterialDetailResponse : TikTokShopResponse<MaterialQueryMaterialDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Material : MaterialSearchMaterialResponse.Types.Data.Types.Material
                    {
                    }
                }

                /// <summary>
                /// 获取或设置素材信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_info")]
                [System.Text.Json.Serialization.JsonPropertyName("material_info")]
                public Types.Material Material { get; set; } = default!;
            }
        }
    }
}
