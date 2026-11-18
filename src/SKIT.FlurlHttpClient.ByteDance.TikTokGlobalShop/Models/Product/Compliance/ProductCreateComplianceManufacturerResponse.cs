namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/compliance/manufacturers 接口的响应。</para>
    /// </summary>
    public class ProductCreateComplianceManufacturerResponse : TikTokShopResponse<ProductCreateComplianceManufacturerResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置制造商 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manufacturer_id")]
                [System.Text.Json.Serialization.JsonPropertyName("manufacturer_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                public string? ManufacturerId { get; set; }
            }
        }
    }
}
