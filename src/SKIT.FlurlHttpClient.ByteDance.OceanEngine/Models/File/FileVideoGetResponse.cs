using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/file/video/get 接口的响应。</para>
    /// </summary>
    public class FileVideoGetResponse : OceanEngineResponse<FileVideoGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Video
                    {
                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string VideoId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频大小（单位：字节）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("size")]
                        [System.Text.Json.Serialization.JsonPropertyName("size")]
                        public int Size { get; set; }

                        /// <summary>
                        /// 获取或设置视频宽度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int Width { get; set; }

                        /// <summary>
                        /// 获取或设置视频高度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int Height { get; set; }

                        /// <summary>
                        /// 获取或设置视频 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string VideoUrl { get; set; } = default!;

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

                        /// <summary>
                        /// 获取或设置素材 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("material_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("material_id")]
                        public long MaterialId { get; set; }

                        /// <summary>
                        /// 获取或设置视频 MD5 哈希值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("signature")]
                        [System.Text.Json.Serialization.JsonPropertyName("signature")]
                        public string Signature { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poster_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("poster_url")]
                        public string PosterUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频比特率（单位：bps）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bit_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("bit_rate")]
                        public int BitRate { get; set; }

                        /// <summary>
                        /// 获取或设置文件名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("filename")]
                        [System.Text.Json.Serialization.JsonPropertyName("filename")]
                        public string FileName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置上传时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置素材来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source")]
                        [System.Text.Json.Serialization.JsonPropertyName("source")]
                        public string? Source { get; set; }

                        /// <summary>
                        /// 获取或设置素材标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("labels")]
                        [System.Text.Json.Serialization.JsonPropertyName("labels")]
                        public string[]? LabelList { get; set; }
                    }

                    public class Pagination : AgentAdvertiserSelectResponse.Types.Data.Types.Pagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Video[] VideoList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Types.Pagination Pagination { get; set; } = default!;
            }
        }
    }
}
