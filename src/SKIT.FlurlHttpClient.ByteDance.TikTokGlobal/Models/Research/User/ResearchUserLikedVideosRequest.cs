using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/user/liked_videos/ 接口的请求。</para>
    /// </summary>
    public class ResearchUserLikedVideosRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置用户名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public long? PageCursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_count")]
        [System.Text.Json.Serialization.JsonPropertyName("max_count")]
        public int? PageSize { get; set; }

        public ResearchUserLikedVideosRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("id");
            FieldList.Add("create_time");
            FieldList.Add("username");
            FieldList.Add("region_code");
            FieldList.Add("video_description");
            FieldList.Add("music_id");
            FieldList.Add("like_count");
            FieldList.Add("comment_count");
            FieldList.Add("share_count");
            FieldList.Add("view_count");
            FieldList.Add("hashtag_names");
            return this;
        }
    }
}
