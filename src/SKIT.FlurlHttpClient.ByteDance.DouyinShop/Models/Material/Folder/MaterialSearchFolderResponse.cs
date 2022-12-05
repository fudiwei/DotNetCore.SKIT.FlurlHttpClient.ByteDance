using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/searchFolder 接口的响应。</para>
    /// </summary>
    public class MaterialSearchFolderResponse : DouyinShopResponse<MaterialSearchFolderResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Folder
                    {
                        /// <summary>
                        /// 获取或设置文件夹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("object_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
                        public string ObjectId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置上级文件夹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                        public string? ParentObjectId { get; set; }

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

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置修改时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset UpdateTime { get; set; }

                        /// <summary>
                        /// 获取或设置删除时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delete_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("delete_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? DeleteTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置文件夹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("folder_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("folder_info_list")]
                public Types.Folder[] FolderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
