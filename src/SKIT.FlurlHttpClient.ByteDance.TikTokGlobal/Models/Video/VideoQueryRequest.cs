using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/query/ 接口的请求。</para>
    /// </summary>
    public class VideoQueryRequest : TikTokV2Request
    {
        public static class Types
        {
            public class Filters
            {
                /// <summary>
                /// 获取或设置视频 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("video_ids")]
                public IList<string>? VideoIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置筛选条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filters")]
        [System.Text.Json.Serialization.JsonPropertyName("filters")]
        public Types.Filters Filters { get; set; } = new Types.Filters();
        
        public VideoQueryRequest SetCompleteFields()
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
