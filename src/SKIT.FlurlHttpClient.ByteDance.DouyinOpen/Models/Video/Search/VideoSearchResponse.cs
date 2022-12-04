namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /video/search 接口的响应。</para>
    /// </summary>
    public class VideoSearchResponse : DouyinOpenResponse<VideoSearchResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class Video : VideoListResponse.Types.Data.Types.Video
                    {
                        /// <summary>
                        /// 获取或设置特殊加密的视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sec_item_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sec_item_id")]
                        public string? SecurityItemId { get; set; }

                        /// <summary>
                        /// 获取或设置作者 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                        public string AuthorOpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置作者昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string AuthorNickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置作者头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avatar")]
                        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                        public string AuthorAvatarUrl { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Video[] VideoList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public long? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
