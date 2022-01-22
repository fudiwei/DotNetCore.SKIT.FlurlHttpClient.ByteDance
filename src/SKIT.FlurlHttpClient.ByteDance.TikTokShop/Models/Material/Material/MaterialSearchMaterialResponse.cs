using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/searchMaterial 接口的响应。</para>
    /// </summary>
    public class MaterialSearchMaterialResponse : TikTokShopResponse<MaterialSearchMaterialResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Material
                    {
                        public static class Types
                        {
                            public class Photo
                            {
                                /// <summary>
                                /// 获取或设置图片高度（单位：像素）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("height")]
                                [System.Text.Json.Serialization.JsonPropertyName("height")]
                                public int Height { get; set; }

                                /// <summary>
                                /// 获取或设置图片宽度（单位：像素）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("width")]
                                [System.Text.Json.Serialization.JsonPropertyName("width")]
                                public int Width { get; set; }

                                /// <summary>
                                /// 获取或设置图片格式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("format")]
                                [System.Text.Json.Serialization.JsonPropertyName("format")]
                                public string Format { get; set; } = default!;
                            }

                            public class Video
                            {
                                /// <summary>
                                /// 获取或设置视频时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("duration")]
                                [System.Text.Json.Serialization.JsonPropertyName("duration")]
                                public double Duration { get; set; }

                                /// <summary>
                                /// 获取或设置视频格式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("format")]
                                [System.Text.Json.Serialization.JsonPropertyName("format")]
                                public string Format { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置素材 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("object_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
                        public string ObjectId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文件夹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                        public string? ParentObjectId { get; set; }

                        /// <summary>
                        /// 获取或设置创建素材时传入的 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("origin_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("origin_url")]
                        public string OriginUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字节存储素材的 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("byte_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("byte_url")]
                        public string ByteUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置素材名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("material_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("material_name")]
                        public string MaterialName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置素材类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("material_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("material_type")]
                        public string MaterialType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置素材状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operate_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("operate_status")]
                        public int OperateStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                        public int AuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审核失败的原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_refuse_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_refuse_reason")]
                        public string? AuditRefuseReason { get; set; }

                        /// <summary>
                        /// 获取或设置文件大小（单位：字节）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("size")]
                        [System.Text.Json.Serialization.JsonPropertyName("size")]
                        public int FileSize { get; set; }

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

                        /// <summary>
                        /// 获取或设置图片信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("photoInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("photoInfo")]
                        public Types.Photo? Photo { get; set; }

                        /// <summary>
                        /// 获取或设置视频信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("videoInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("videoInfo")]
                        public Types.Video? Video { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置素材列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("material_info_list")]
                public Types.Material[] MaterialList { get; set; } = default!;

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
