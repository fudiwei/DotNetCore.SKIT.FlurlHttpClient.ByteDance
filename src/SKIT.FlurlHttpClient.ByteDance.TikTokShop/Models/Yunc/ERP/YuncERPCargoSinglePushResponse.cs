namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/erpCargoSinglePush 接口的响应。</para>
    /// </summary>
    public class YuncERPCargoSinglePushResponse : TikTokShopResponse<YuncERPCargoSinglePushResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置 ERP SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("erp_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("erp_sku_id")]
                public string ERPSKUId { get; set; } = default!;

                /// <summary>
                /// 获取或设置货品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_code")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_code")]
                public string CargoCode { get; set; } = default!;
            }
        }
    }
}
