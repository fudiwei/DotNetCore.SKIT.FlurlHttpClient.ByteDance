namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /spu/getSpuTpl 接口的请求。</para>
    /// </summary>
    public class SPUGetSPUTemplateRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public int CategoryId { get; set; }
    }
}
