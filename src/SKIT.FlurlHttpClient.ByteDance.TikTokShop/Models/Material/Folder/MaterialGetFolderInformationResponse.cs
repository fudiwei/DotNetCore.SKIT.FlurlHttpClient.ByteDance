namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/getFolderInfo 接口的响应。</para>
    /// </summary>
    public class MaterialGetFolderInformationResponse : TikTokShopResponse<MaterialGetFolderInformationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ChildFolder
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
                        public string FolderName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文件夹类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("folder_object_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("folder_object_type")]
                        public int FolderType { get; set; }

                        /// <summary>
                        /// 获取或设置文件夹状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operate_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("operate_status")]
                        public int OperateStatus { get; set; }
                    }

                    public class ChildMaterial : MaterialSearchMaterialResponse.Types.Data.Types.Material
                    {
                    }

                    public class Folder : ChildFolder
                    {
                        /// <summary>
                        /// 获取或设置子文件夹列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("child_folder")]
                        [System.Text.Json.Serialization.JsonPropertyName("child_folder")]
                        public Types.ChildFolder[] ChildFolderList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置素材列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("child_material")]
                        [System.Text.Json.Serialization.JsonPropertyName("child_material")]
                        public Types.ChildMaterial[] ChildMaterialList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文件夹下的素材个数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total")]
                        [System.Text.Json.Serialization.JsonPropertyName("total")]
                        public int TotalChildMaterialCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置文件夹信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("folder_info")]
                [System.Text.Json.Serialization.JsonPropertyName("folder_info")]
                public Types.Folder Folder { get; set; } = default!;
            }
        }
    }
}
