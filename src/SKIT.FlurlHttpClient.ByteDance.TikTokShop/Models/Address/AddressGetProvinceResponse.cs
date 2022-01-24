namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /address/getProvince 接口的响应。</para>
    /// </summary>
    public class AddressGetProvinceResponse : TikTokShopResponse<AddressGetProvinceResponse.Types.Province[]>
    {
        public static class Types
        {
            public class Province
            {
                /// <summary>
                /// 获取或设置省份 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_id")]
                [System.Text.Json.Serialization.JsonPropertyName("province_id")]
                public int ProvinceId { get; set; }

                /// <summary>
                /// 获取或设置省份名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string ProvinceName { get; set; } = default!;
            }
        }
    }
}
