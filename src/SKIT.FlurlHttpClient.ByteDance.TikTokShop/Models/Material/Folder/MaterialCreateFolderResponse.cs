namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/createFolder 接口的响应。</para>
    /// </summary>
    public class MaterialCreateFolderResponse : TikTokShopResponse<MaterialCreateFolderResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置文件夹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("object_id")]
                [System.Text.Json.Serialization.JsonPropertyName("object_id")]
                public string ObjectId { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件夹名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

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
    }
}
