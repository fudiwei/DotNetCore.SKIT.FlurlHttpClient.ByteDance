namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/video/query/ 接口的响应。</para>
    /// </summary>
    public class ResearchVideoQueryResponse : TikTokV2Response<ResearchVideoQueryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Video
                    {
                        public static class Types
                        {
                            public class HashTagInfo
                            {
                                /// <summary>
                                /// 获取或设置话题标签 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("hashtag_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("hashtag_id")]
                                public string? HashTagId { get; set; }

                                /// <summary>
                                /// 获取或设置话题标签描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("hashtag_description")]
                                [System.Text.Json.Serialization.JsonPropertyName("hashtag_description")]
                                public string? HashTagDescription { get; set; }
                            }

                            public class StickerInfo
                            {
                                /// <summary>
                                /// 获取或设置表情贴纸 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sticker_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sticker_id")]
                                public string? StickerId { get; set; }

                                /// <summary>
                                /// 获取或设置表情贴纸名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sticker_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("sticker_name")]
                                public string? StickerName { get; set; }
                            }

                            public class EffectInfo
                            {
                                /// <summary>
                                /// 获取或设置特效 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("effect_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("effect_id")]
                                public string? EffectId { get; set; }

                                /// <summary>
                                /// 获取或设置特效名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("effect_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("effect_name")]
                                public string? EffectName { get; set; }

                                /// <summary>
                                /// 获取或设置特效照片 URl。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("effect_photo_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("effect_photo_url")]
                                public string? EffectPhotoUrl { get; set; }
                            }

                            public class VideoTag
                            {
                                /// <summary>
                                /// 获取或设置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string? Type { get; set; }

                                /// <summary>
                                /// 获取或设置编号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("number")]
                                [System.Text.Json.Serialization.JsonPropertyName("number")]
                                public int Number { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long VideoId { get; set; }

                        /// <summary>
                        /// 获取或设置作者用户名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("username")]
                        [System.Text.Json.Serialization.JsonPropertyName("username")]
                        public string? Username { get; set; }

                        /// <summary>
                        /// 获取或设置地区代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("region_code")]
                        public string? RegionCode { get; set; }

                        /// <summary>
                        /// 获取或设置视频描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_description")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置点赞次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("like_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("like_count")]
                        public long LikeCount { get; set; }

                        /// <summary>
                        /// 获取或设置评论次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_count")]
                        public long CommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置分享次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_count")]
                        public long ShareCount { get; set; }

                        /// <summary>
                        /// 获取或设置观看次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("view_count")]
                        public long ViewCount { get; set; }

                        /// <summary>
                        /// 获取或设置收藏次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("favorites_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("favorites_count")]
                        public long FavoritesCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置视频时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_duration")]
                        public int VideoDuration { get; set; }

                        /// <summary>
                        /// 获取或设置音乐 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("music_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("music_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long? MusicId { get; set; }

                        /// <summary>
                        /// 获取或设置特效 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("effect_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("effect_ids")]
                        public List<string>? EffectIdList { get; set; }

                        /// <summary>
                        /// 获取或设置话题标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hashtag_names")]
                        [System.Text.Json.Serialization.JsonPropertyName("hashtag_names")]
                        public List<string>? HashtagNameList { get; set; }

                        /// <summary>
                        /// 获取或设置话题标签信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hashtag_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("hashtag_info_list")]
                        public List<Types.HashTagInfo>? HashTagInfoList { get; set; }

                        /// <summary>
                        /// 获取或设置表情贴纸信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sticker_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("sticker_info_list")]
                        public List<Types.StickerInfo>? StickerInfoList { get; set; }

                        /// <summary>
                        /// 获取或设置特效信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("effect_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("effect_info_list")]
                        public List<Types.EffectInfo>? EffectInfoList { get; set; }

                        /// <summary>
                        /// 获取或设置提及列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_mention_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_mention_list")]
                        public List<string>? VideoMentionList { get; set; }

                        /// <summary>
                        /// 获取或设置视频标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_tag")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_tag")]
                        public List<Types.VideoTag>? VideoTagList { get; set; }

                        /// <summary>
                        /// 获取或设置播放列表 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("playlist_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long? PlaylistId { get; set; }

                        /// <summary>
                        /// 获取或设置语音转文本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("voice_to_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("voice_to_text")]
                        public string? VoiceToText { get; set; }

                        /// <summary>
                        /// 获取或设置是否已通过 STEM 认证。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_stem_verified")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_stem_verified")]
                        public bool? IsSTEMVerified { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("videos")]
                [System.Text.Json.Serialization.JsonPropertyName("videos")]
                public List<Types.Video>? VideoList { get; set; }

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }

                /// <summary>
                /// 获取或设置搜索结果 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("search_id")]
                [System.Text.Json.Serialization.JsonPropertyName("search_id")]
                public string? SearchId { get; set; }
            }
        }
    }
}
