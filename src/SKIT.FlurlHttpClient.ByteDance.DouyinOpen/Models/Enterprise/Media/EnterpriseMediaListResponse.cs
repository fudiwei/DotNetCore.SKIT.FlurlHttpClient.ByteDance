namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /enterprise/media/list 接口的响应。</para>
    /// </summary>
    public class EnterpriseMediaListResponse : DouyinOpenResponse<EnterpriseMediaListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Media
                    {
                        /// <summary>
                        /// 获取或设置素材 ID
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string MediaId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置素材状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置素材的 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("url_list")]
                        public string[] UrlList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置素材列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("medias")]
                [System.Text.Json.Serialization.JsonPropertyName("medias")]
                public Types.Media[] MediaList { get; set; } = default!;

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
