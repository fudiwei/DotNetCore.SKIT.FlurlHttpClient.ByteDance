namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /enterprise/leads/tag/list 接口的响应。</para>
    /// </summary>
    public class EnterpriseLeadsTagListResponse : TikTokResponse<EnterpriseLeadsTagListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class Tag
                    {
                        /// <summary>
                        /// 获取或设置标签 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
                        public long TagId { get; set; }

                        /// <summary>
                        /// 获取或设置标签名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_name")]
                        public string TagName { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Tag[] TagList { get; set; } = default!;

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
