namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/uploadVideoAsync 接口的请求。</para>
    /// </summary>
    public class MaterialUploadVideoAsyncRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置上级文件夹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentObjectId { get; set; }

        /// <summary>
        /// 获取或设置视频名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string VideoName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string VideoUrl { get; set; } = string.Empty;
    }
}
