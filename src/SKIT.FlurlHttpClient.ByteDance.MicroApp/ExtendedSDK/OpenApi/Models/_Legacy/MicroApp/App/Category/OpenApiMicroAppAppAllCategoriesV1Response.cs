using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/app/all_categories 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-23 下线。")]
    public class OpenApiMicroAppAppAllCategoriesV1Response : DouyinMicroAppOpenApiLegacyResponseBase
    {
        public static class Types
        {
            public class Category
            {
                public static class Types
                {
                    public class Certification
                    {
                        public static class Types
                        {
                            public class Detail
                            {
                                /// <summary>
                                /// 获取或设置资质 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int Id { get; set; }

                                /// <summary>
                                /// 获取或设置资质名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置需要的资质汇总列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("relation")]
                        [System.Text.Json.Serialization.JsonPropertyName("relation")]
                        public string[] RelationList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置需要的资质的详细信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("list")]
                        [System.Text.Json.Serialization.JsonPropertyName("list")]
                        public Types.Detail[] DetailList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置解释说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("explanation")]
                        [System.Text.Json.Serialization.JsonPropertyName("explanation")]
                        public string Explanation { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置服务类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int Id { get; set; }

                /// <summary>
                /// 获取或设置服务类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务类目级别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public int Level { get; set; }

                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fpid")]
                [System.Text.Json.Serialization.JsonPropertyName("fpid")]
                public int? FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spid")]
                [System.Text.Json.Serialization.JsonPropertyName("spid")]
                public int? SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置需要的资质信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certification")]
                [System.Text.Json.Serialization.JsonPropertyName("certification")]
                public Types.Certification? Certification { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Category[] CategoryList { get; set; } = default!;
    }
}
