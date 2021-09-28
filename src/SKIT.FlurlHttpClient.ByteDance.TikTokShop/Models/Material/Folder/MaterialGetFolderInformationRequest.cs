namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/getFolderInfo 接口的请求。</para>
    /// </summary>
    public class MaterialGetFolderInformationRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置文件夹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_id")]
        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public string ObjectId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        [System.Text.Json.Serialization.JsonPropertyName("page_num")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// <para>默认值：50</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 50;
    }
}
