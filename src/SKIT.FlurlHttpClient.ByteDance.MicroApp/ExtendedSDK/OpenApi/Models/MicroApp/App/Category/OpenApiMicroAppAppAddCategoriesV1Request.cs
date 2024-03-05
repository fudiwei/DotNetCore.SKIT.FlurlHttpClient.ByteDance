using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/add_categories 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppAppAddCategoriesV1Request : DouyinMicroAppOpenApiRequest
    {
        public static class Types
        {
            public class CategoryInfo
            {
                public static class Types
                {
                    public class Certification
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
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置资质文件路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string FilePath { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置服务类目 ID 字符串（以逗号分隔）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public string CategoryIdString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置服务类目资质信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("categoryCert")]
                [System.Text.Json.Serialization.JsonPropertyName("categoryCert")]
                public IList<Types.Certification>? CertificationList { get; set; }
            }
        }


        /// <summary>
        /// 获取或设置服务类目信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categoryInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("categoryInfo")]
        public IList<Types.CategoryInfo> CategoryInfoList { get; set; } = new List<Types.CategoryInfo>();
    }
}
