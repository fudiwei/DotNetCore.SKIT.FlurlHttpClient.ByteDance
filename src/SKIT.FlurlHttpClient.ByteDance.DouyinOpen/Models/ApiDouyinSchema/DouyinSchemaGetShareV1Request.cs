using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/schema/get_share/ 接口的请求。</para>
    /// </summary>
    public class DouyinSchemaGetShareV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class MicroApp
            {
                /// <summary>
                /// 获取或设置客户端凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_title")]
                [System.Text.Json.Serialization.JsonPropertyName("app_title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_url")]
                [System.Text.Json.Serialization.JsonPropertyName("app_url")]
                public string PagePath { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序描述语	。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客户端凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("client_ticket")]
        public string ClientTicket { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置凭证过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_at")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_at")]
        public long ExpireTimestamp { get; set; }

        /// <summary>
        /// 获取或设置话题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hashtag_list")]
        [System.Text.Json.Serialization.JsonPropertyName("hashtag_list")]
        public IList<string>? HashTagList { get; set; }

        /// <summary>
        /// 获取或设置图片 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_list_path")]
        [System.Text.Json.Serialization.JsonPropertyName("image_list_path")]
        public IList<string>? ImageUrlList { get; set; }

        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_path")]
        [System.Text.Json.Serialization.JsonPropertyName("image_path")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 获取或设置小程序信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("micro_app_info")]
        [System.Text.Json.Serialization.JsonPropertyName("micro_app_info")]
        public Types.MicroApp? MicroApp { get; set; }

        /// <summary>
        /// 获取或设置 POI ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string? POIId { get; set; }

        /// <summary>
        /// 获取或设置分享到抖音发布页状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_to_publish")]
        [System.Text.Json.Serialization.JsonPropertyName("share_to_publish")]
        public int? ShareToPublishState { get; set; }

        /// <summary>
        /// 获取或设置分享携带参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置视频标题	。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? VideoTitle { get; set; }

        /// <summary>
        /// 获取或设置视频 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_path")]
        [System.Text.Json.Serialization.JsonPropertyName("video_path")]
        public string? VideoUrl { get; set; }
    }
}
