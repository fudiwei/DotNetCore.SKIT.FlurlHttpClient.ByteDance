namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/editFolder 接口的请求。</para>
    /// </summary>
    public class MaterialEditFolderRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置文件夹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_id")]
        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public string ObjectId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新的文件夹名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string FolderName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新的上级文件夹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_parent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("to_parent_id")]
        public string? ToParentObjectId { get; set; }
    }
}
