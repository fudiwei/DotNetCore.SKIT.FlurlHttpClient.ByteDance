namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/uploadImageSync 接口的请求。</para>
    /// </summary>
    public class MaterialUploadImageSyncRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置上级文件夹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentObjectId { get; set; }

        /// <summary>
        /// 获取或设置图片名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material_name")]
        [System.Text.Json.Serialization.JsonPropertyName("material_name")]
        public string ImageName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
