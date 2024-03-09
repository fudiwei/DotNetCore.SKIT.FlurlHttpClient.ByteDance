namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /tpapp/v2/template/get_tpl_list 接口的响应。</para>
    /// </summary>
    public class OpenTpAppTemplateGetTemplateListV2Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Template
                    {
                        /// <summary>
                        /// 获取或设置模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                        public long TemplateId { get; set; }

                        /// <summary>
                        /// 获取或设置版本号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_version")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_version")]
                        public string UserVersion { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
                        public string UserDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_list")]
                [System.Text.Json.Serialization.JsonPropertyName("template_list")]
                public Types.Template[] TemplateList { get; set; } = default!;
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
