namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/media/upload 接口的响应。</para>
    /// </summary>
    public class EnterpriseMediaUploadResponse : DouyinOpenResponse<EnterpriseMediaUploadResponse.Types.Data>
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
                        /// 获取或设置素材 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string MediaId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置素材的 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("url_list")]
                        public string[] UrlList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置素材信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media")]
                [System.Text.Json.Serialization.JsonPropertyName("media")]
                public Types.Media Media { get; set; } = default!;
            }
        }
    }
}
