using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/list/ 接口的请求。</para>
    /// </summary>
    public class VideoListRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

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

        public VideoListRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("id");
            FieldList.Add("create_time");
            FieldList.Add("cover_image_url");
            FieldList.Add("share_url");
            FieldList.Add("video_description");
            FieldList.Add("duration");
            FieldList.Add("height");
            FieldList.Add("width");
            FieldList.Add("title");
            FieldList.Add("embed_html");
            FieldList.Add("embed_link");
            FieldList.Add("like_count");
            FieldList.Add("comment_count");
            FieldList.Add("share_count");
            FieldList.Add("view_count");
            return this;
        }
    }
}
