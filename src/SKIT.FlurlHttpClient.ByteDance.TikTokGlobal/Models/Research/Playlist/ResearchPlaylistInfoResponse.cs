namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/playlist/info/ 接口的响应。</para>
    /// </summary>
    public class ResearchPlaylistInfoResponse : TikTokV2Response<ResearchPlaylistInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置播放列表 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("playlist_id")]
                [System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
                public long PlaylistId { get; set; }

                /// <summary>
                /// 获取或设置播放列表名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("playlist_name")]
                [System.Text.Json.Serialization.JsonPropertyName("playlist_name")]
                public string PlaylistName { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频总数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("playlist_item_total")]
                [System.Text.Json.Serialization.JsonPropertyName("playlist_item_total")]
                public int TotalItemCount { get; set; }

                /// <summary>
                /// 获取或设置最后更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("playlist_last_updated")]
                [System.Text.Json.Serialization.JsonPropertyName("playlist_last_updated")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置视频 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("playlist_video_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("playlist_video_ids")]
                public long[]? VideoIdList { get; set; }
            }
        }
    }
}
