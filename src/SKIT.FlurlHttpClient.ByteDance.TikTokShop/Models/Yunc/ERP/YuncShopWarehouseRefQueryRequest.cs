namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/shopWarehouseRefQuery 接口的请求。</para>
    /// </summary>
    public class YuncShopWarehouseRefQueryRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public int ShopId { get; set; }
    }
}
