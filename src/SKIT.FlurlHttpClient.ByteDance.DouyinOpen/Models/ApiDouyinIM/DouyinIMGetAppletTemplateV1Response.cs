namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/im/get_applet_template/ 接口的响应。</para>
    /// </summary>
    public class DouyinIMGetAppletTemplateV1Response : DouyinOpenResponse<DouyinIMGetAppletTemplateV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Card
                    {
                        /// <summary>
                        /// 获取或设置模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_template_id")]
                        public string CardTemplateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卡片类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
                        public int CardType { get; set; }

                        /// <summary>
                        /// 获取或设置卡片标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卡片内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string MediaId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        public string MicroAppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string MicroAppName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序图标 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_icon_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_icon_url")]
                        public string MicroAppIconUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置卡片状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reasons")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reasons")]
                        public string? RejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Card[] CardList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public long? NextCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
