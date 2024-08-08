namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/playlist/info/ 接口的请求。</para>
    /// </summary>
    public class ResearchPlaylistInfoRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置播放列表 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("playlist_id")]
        [System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
        public long PlaylistId { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public long? PageCursor { get; set; }
    }
}
