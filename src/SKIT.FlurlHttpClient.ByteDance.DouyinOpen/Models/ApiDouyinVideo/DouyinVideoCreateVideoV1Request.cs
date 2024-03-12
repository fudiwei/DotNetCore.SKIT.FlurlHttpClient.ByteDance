using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/video/create_video/ 接口的请求。</para>
    /// </summary>
    public class DouyinVideoCreateVideoV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_id")]
        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public string VideoId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string? POIId { get; set; }

        /// <summary>
        /// 获取或设置门店名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_name")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_name")]
        public string? POIName { get; set; }

        /// <summary>
        /// 获取或设置开启门店推广。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_commerce")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_commerce")]
        public bool? POICommerce { get; set; }

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
        /// 获取或设置文章 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_id")]
        [System.Text.Json.Serialization.JsonPropertyName("article_id")]
        public string? ArticleId { get; set; }

        /// <summary>
        /// 获取或设置文章标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_title")]
        [System.Text.Json.Serialization.JsonPropertyName("article_title")]
        public string? ArticleTitle { get; set; }

        /// <summary>
        /// 获取或设置时效新闻标签。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeliness_label")]
        [System.Text.Json.Serialization.JsonPropertyName("timeliness_label")]
        public int? TimelineLabel { get; set; }

        /// <summary>
        /// 获取或设置时效新闻关键字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeliness_keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("timeliness_keyword")]
        public string? TimelineKeyword { get; set; }

        /// <summary>
        /// 获取或设置游戏 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("game_id")]
        [System.Text.Json.Serialization.JsonPropertyName("game_id")]
        public string? GameId { get; set; }

        /// <summary>
        /// 获取或设置游戏个性化参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("game_content")]
        [System.Text.Json.Serialization.JsonPropertyName("game_content")]
        public string? GameContent { get; set; }

        /// <summary>
        /// 获取或设置将传入的指定时间点对应帧设置为视频封面（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_tsp")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_tsp")]
        public decimal? CoverTSP { get; set; }

        /// <summary>
        /// 获取或设置封面图片 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_cover_image_url")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_cover_image_url")]
        public string? CoverImageId { get; set; }

        /// <summary>
        /// 获取或设置 @用户 的 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("at_users")]
        [System.Text.Json.Serialization.JsonPropertyName("at_users")]
        public IList<string>? AtUserOpenIdList { get; set; }

        /// <summary>
        /// 获取或设置影视 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
        public string? EntertainmentId { get; set; }
    }
}
