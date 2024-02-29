using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /post/publish/content/init/ 接口的请求。</para>
    /// </summary>
    public class PostPublishContentInitRequest : TikTokV2Request
    {
        public static class Types
        {
            public class PostInfo
            {
                /// <summary>
                /// 获取或设置隐私级别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privacy_level")]
                [System.Text.Json.Serialization.JsonPropertyName("privacy_level")]
                public string? PrivacyLevel { get; set; }

                /// <summary>
                /// 获取或设置标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置是否禁止评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("disable_comment")]
                [System.Text.Json.Serialization.JsonPropertyName("disable_comment")]
                public bool? DisableComment { get; set; }

                /// <summary>
                /// 获取或设置是否自动添加音乐。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auto_add_music")]
                [System.Text.Json.Serialization.JsonPropertyName("auto_add_music")]
                public bool? AutoAddMusic { get; set; }

                /// <summary>
                /// 获取或设置是否是第三方品牌推广内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_content_toggle")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_content_toggle")]
                public bool? IsBrandContent { get; set; }

                /// <summary>
                /// 获取或设置是否是自有品牌推广内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_organic_toggle")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_organic_toggle")]
                public bool? IsBrandOrganic { get; set; }
            }

            public class SourceInfo
            {
                /// <summary>
                /// 获取或设置视频来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string Source { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置照片图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("photo_images")]
                [System.Text.Json.Serialization.JsonPropertyName("photo_images")]
                public IList<string>? PhotoImageUrlList { get; set; }

                /// <summary>
                /// 获取或设置照片封面索引。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("photo_cover_index")]
                [System.Text.Json.Serialization.JsonPropertyName("photo_cover_index")]
                public int? PhotoCoverIndex { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置媒体类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_type")]
        [System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public string MediaType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上传模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("post_mode")]
        public string PostMode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上传信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_info")]
        [System.Text.Json.Serialization.JsonPropertyName("post_info")]
        public Types.PostInfo PostInfo { get; set; } = new Types.PostInfo();

        /// <summary>
        /// 获取或设置源文件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_info")]
        [System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public Types.SourceInfo SourceInfo { get; set; } = new Types.SourceInfo();
    }
}
