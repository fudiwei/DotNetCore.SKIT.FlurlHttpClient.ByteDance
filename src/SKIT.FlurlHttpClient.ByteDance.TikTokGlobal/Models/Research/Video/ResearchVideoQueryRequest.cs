using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/video/query/ 接口的请求。</para>
    /// </summary>
    public class ResearchVideoQueryRequest : TikTokV2Request
    {
        public static class Types
        {
            public class Query
            {
                public static class Types
                {
                    public class Condition
                    {
                        /// <summary>
                        /// 获取或设置运算符。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operation")]
                        [System.Text.Json.Serialization.JsonPropertyName("operation")]
                        public string Operation { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置字段名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_name")]
                        public string FieldName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置字段值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_values")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_values")]
                        public IList<string> FieldValues { get; set; } = new List<string>();
                    }
                }

                /// <summary>
                /// 获取或设置“和”条件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("and")]
                [System.Text.Json.Serialization.JsonPropertyName("and")]
                public IList<Types.Condition>? And { get; set; }

                /// <summary>
                /// 获取或设置“或”条件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("or")]
                [System.Text.Json.Serialization.JsonPropertyName("or")]
                public IList<Types.Condition>? Or { get; set; }

                /// <summary>
                /// 获取或设置“否”条件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("not")]
                [System.Text.Json.Serialization.JsonPropertyName("not")]
                public IList<Types.Condition>? Not { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置查询条件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public Types.Query Query { get; set; } = new Types.Query();

        /// <summary>
        /// 获取或设置开始日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_date")]
        [System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public string StartDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结束日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string EndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置搜索结果标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_id")]
        [System.Text.Json.Serialization.JsonPropertyName("search_id")]
        public string? SearchId { get; set; }

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

        /// <summary>
        /// 获取或设置是否随机排序。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_random")]
        [System.Text.Json.Serialization.JsonPropertyName("is_random")]
        public bool? IsRandom { get; set; }

        public ResearchVideoQueryRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("id");
            FieldList.Add("video_description");
            FieldList.Add("create_time");
            FieldList.Add("region_code");
            FieldList.Add("share_count");
            FieldList.Add("view_count");
            FieldList.Add("like_count");
            FieldList.Add("comment_count");
            FieldList.Add("music_id");
            FieldList.Add("hashtag_names");
            FieldList.Add("username");
            FieldList.Add("effect_ids");
            FieldList.Add("playlist_id");
            FieldList.Add("voice_to_text");
            return this;
        }
    }
}
