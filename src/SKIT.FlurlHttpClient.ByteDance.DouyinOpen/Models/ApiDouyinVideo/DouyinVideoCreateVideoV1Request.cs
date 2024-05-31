using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/video/create_video/ 接口的请求。</para>
    /// </summary>
    public class DouyinVideoCreateVideoV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class VRTranscodeParameter
            {
                public static class Types
                {
                    public class VideoStyle
                    {
                        /// <summary>
                        /// 获取或设置维度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dimention")]
                        [System.Text.Json.Serialization.JsonPropertyName("dimention")]
                        public int Dimention { get; set; }

                        /// <summary>
                        /// 获取或设置投影模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("projection_model")]
                        [System.Text.Json.Serialization.JsonPropertyName("projection_model")]
                        public int ProjectionModel { get; set; }

                        /// <summary>
                        /// 获取或设置视野范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("vstyle")]
                        [System.Text.Json.Serialization.JsonPropertyName("vstyle")]
                        public int ViewSize { get; set; }

                        /// <summary>
                        /// 获取或设置视频类型。
                        /// <para>默认值：1</para>
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view_size")]
                        [System.Text.Json.Serialization.JsonPropertyName("view_size")]
                        public int Style { get; set; } = 1;
                    }
                }

                /// <summary>
                /// 获取或设置视频格式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_style")]
                [System.Text.Json.Serialization.JsonPropertyName("video_style")]
                public Types.VideoStyle? VideoStyle { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置中介 ClientKey。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("agent_client_key")]
        public string? AgentClientKey { get; set; }

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
        /// 获取或设置下载类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_type")]
        [System.Text.Json.Serialization.JsonPropertyName("download_type")]
        public int? DownloadType { get; set; }

        /// <summary>
        /// 获取或设置可见范围控制状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("private_status")]
        [System.Text.Json.Serialization.JsonPropertyName("private_status")]
        public int? PrivateStatus { get; set; }

        /// <summary>
        /// 获取或设置影视 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
        public string? EntertainmentId { get; set; }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 获取或设置全景视频参数信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vr_transcode_extra_params")]
        [System.Text.Json.Serialization.JsonPropertyName("vr_transcode_extra_params")]
        public Types.VRTranscodeParameter? VRTranscodeParameter { get; set; }
    }
}
