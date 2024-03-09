namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /tpapp/v2/template/get_tpl_app_list 接口的响应。</para>
    /// </summary>
    public class OpenTpAppTemplateGetTemplateAppListV2Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class TemplateApp
                    {
                        /// <summary>
                        /// 获取或设置模板小程序 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tpl_app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("tpl_app_id")]
                        public string TemplateAppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置模板小程序名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                        public string AppName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置上传当前版本的用户名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nick_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                        public string? Nickname { get; set; }

                        /// <summary>
                        /// 获取或设置版本号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_version")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_version")]
                        public string? UserVersion { get; set; }

                        /// <summary>
                        /// 获取或设置描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
                        public string? UserDescription { get; set; }

                        /// <summary>
                        /// 获取或设置草稿 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("draft_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("draft_id")]
                        public long? DraftId { get; set; }

                        /// <summary>
                        /// 获取或设置上传时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long? CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板小程序列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tpl_app_list")]
                [System.Text.Json.Serialization.JsonPropertyName("tpl_app_list")]
                public Types.TemplateApp[] TemplateAppList { get; set; } = default!;
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
