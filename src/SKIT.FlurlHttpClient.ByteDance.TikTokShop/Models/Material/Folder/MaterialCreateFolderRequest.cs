namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/createFolder 接口的请求。</para>
    /// </summary>
    public class MaterialCreateFolderRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置文件夹名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string FolderName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上级文件夹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentObjectId { get; set; }

        /// <summary>
        /// 获取或设置文件夹类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }
    }
}
