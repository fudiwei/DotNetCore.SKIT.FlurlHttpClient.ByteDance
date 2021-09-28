namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /address/getAreasByProvince 接口的请求。</para>
    /// </summary>
    public class AddressGetAreasByProvinceRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置省份 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_id")]
        [System.Text.Json.Serialization.JsonPropertyName("province_id")]
        public int ProvinceId { get; set; }
    }
}
