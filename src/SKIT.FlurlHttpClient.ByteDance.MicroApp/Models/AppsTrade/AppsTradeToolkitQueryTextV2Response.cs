namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/toolkit/query_text 接口的响应。</para>
    /// </summary>
    public class AppsTradeToolkitQueryTextV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Text
                    {
                        public static class Types
                        {
                            public class Content
                            {
                                /// <summary>
                                /// 获取或设置文案 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("text_id")]
                                public string TextId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置文案内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text_content")]
                                [System.Text.Json.Serialization.JsonPropertyName("text_content")]
                                public string TextContent { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置文案类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("text_type")]
                        public int TextType { get; set; }

                        /// <summary>
                        /// 获取或设置文案内容列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text_content_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("text_content_list")]
                        public Types.Content[] ContentList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置文案列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text_list")]
                [System.Text.Json.Serialization.JsonPropertyName("text_list")]
                public Types.Text[] TextList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
