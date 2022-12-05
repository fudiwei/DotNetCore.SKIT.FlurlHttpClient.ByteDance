namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/queryMaterialDetail 接口的请求。</para>
    /// </summary>
    public class MaterialQueryMaterialDetailRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置素材 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_id")]
        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public string ObjectId { get; set; } = string.Empty;
    }
}
