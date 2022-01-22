namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/brandList 接口的响应。</para>
    /// </summary>
    public class ShopBandListResponse : TikTokShopResponse<ShopBandListResponse.Types.Brand[]>
    {
        public static class Types
        {
            public class Brand
            {
                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int BrandId { get; set; }

                /// <summary>
                /// 获取或设置中文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_chinese_name")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_chinese_name")]
                public string ChineseName { get; set; } = default!;

                /// <summary>
                /// 获取或设置英文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_english_name")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_english_name")]
                public string EnglishName { get; set; } = default!;

                /// <summary>
                /// 获取或设置商标注册号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_reg_num")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_reg_num")]
                public string RegisterNumber { get; set; } = default!;
            }
        }
    }
}
