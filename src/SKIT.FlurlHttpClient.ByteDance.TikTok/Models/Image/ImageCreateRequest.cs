using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /image/create 接口的请求。</para>
    /// </summary>
    public class ImageCreateRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置图片 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_id")]
        [System.Text.Json.Serialization.JsonPropertyName("image_id")]
        public string ImageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置地理位置 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string? POIId { get; set; }

        /// <summary>
        /// 获取或设置地理位置名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_name")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_name")]
        public string? POIName { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("micro_app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("micro_app_id")]
        public string? MicroAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("micro_app_title")]
        [System.Text.Json.Serialization.JsonPropertyName("micro_app_title")]
        public string? MicroAppTitle { get; set; }

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("micro_app_url")]
        [System.Text.Json.Serialization.JsonPropertyName("micro_app_url")]
        public string? MicroAppPagePath { get; set; }

        /// <summary>
        /// 获取或设置 @用户 的 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("at_users")]
        [System.Text.Json.Serialization.JsonPropertyName("at_users")]
        public IList<string>? AtUserOpenIdList { get; set; }
    }
}
