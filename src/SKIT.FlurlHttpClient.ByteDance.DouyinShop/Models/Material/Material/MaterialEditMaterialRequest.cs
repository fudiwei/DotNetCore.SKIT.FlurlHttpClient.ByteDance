namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/editMaterial 接口的请求。</para>
    /// </summary>
    public class MaterialEditMaterialRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置文件夹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_id")]
        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public string ObjectId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新的素材名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material_name")]
        [System.Text.Json.Serialization.JsonPropertyName("material_name")]
        public string MaterialName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新的上级文件夹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_parent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("to_parent_id")]
        public string? ToParentObjectId { get; set; }
    }
}
