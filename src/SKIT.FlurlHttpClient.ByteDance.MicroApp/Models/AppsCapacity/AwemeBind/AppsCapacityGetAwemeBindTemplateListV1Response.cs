using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/capacity/get_aweme_bind_template_list/ 接口的响应。</para>
    /// </summary>
    public class AppsCapacityGetAwemeBindTemplateListV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class TemplateInfo
                    {
                        /// <summary>
                        /// 获取或设置模版 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long TemplateId { get; set; }

                        /// <summary>
                        /// 获取或设置模版标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置所属的类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        public string CategoryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置所属的类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                        public string CategoryName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否可以使用。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_apply")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_apply")]
                        public bool CanApply { get; set; }

                        /// <summary>
                        /// 获取或设置不可使用的原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? Reason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置资质模版字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_map")]
                [System.Text.Json.Serialization.JsonPropertyName("template_map")]
                public IDictionary<string, Types.TemplateInfo[]> TemplateInfoMap { get; set; } = default!;
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
