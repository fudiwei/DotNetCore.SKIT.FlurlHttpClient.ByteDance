namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /post/publish/creator_info/query/ 接口的响应。</para>
    /// </summary>
    public class PostPublishCreatorInfoQueryResponse : TikTokV2Response<PostPublishCreatorInfoQueryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置创作者头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator_avatar_url")]
                [System.Text.Json.Serialization.JsonPropertyName("creator_avatar_url")]
                public string CreatorAvatarUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置创作者 TikTok 账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator_username")]
                [System.Text.Json.Serialization.JsonPropertyName("creator_username")]
                public string CreatorUsername { get; set; } = default!;

                /// <summary>
                /// 获取或设置创作者昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator_nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("creator_nickname")]
                public string CreatorNickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置隐私级别选项。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privacy_level_options")]
                [System.Text.Json.Serialization.JsonPropertyName("privacy_level_options")]
                public string[] PrivacyLevelOptions { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否禁止二重奏。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("duet_disabled")]
                [System.Text.Json.Serialization.JsonPropertyName("duet_disabled")]
                public bool IsDuetDisabled { get; set; }

                /// <summary>
                /// 获取或设置是否禁止拼接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stitch_disabled")]
                [System.Text.Json.Serialization.JsonPropertyName("stitch_disabled")]
                public bool IsStitchDisabled { get; set; }

                /// <summary>
                /// 获取或设置是否禁止评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_disabled")]
                [System.Text.Json.Serialization.JsonPropertyName("comment_disabled")]
                public bool IsCommentDisabled { get; set; }

                /// <summary>
                /// 获取或设置可上传视频最大时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_video_post_duration_sec")]
                [System.Text.Json.Serialization.JsonPropertyName("max_video_post_duration_sec")]
                public int MaxVideoPostDuration { get; set; }
            }
        }
    }
}
