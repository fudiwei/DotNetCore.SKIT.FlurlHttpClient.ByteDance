using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/category/supply_categories 接口的请求。</para>
    /// </summary>
    public class OpenAppsCategorySupplyCategoriesV1Request : DouyinMicroAppOpenApiRequest
    {
        public static class Types
        {
            public class CategoryInfo 
            {
                public static class Types
                {
                    public class Certification : OpenAppsCategoryAddCategoriesV1Request.Types.CategoryInfo.Types.Certification
                    {
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
                [Newtonsoft.Json.JsonProperty("category_cert")]
                [System.Text.Json.Serialization.JsonPropertyName("category_cert")]
                public IList<Types.Certification>? CertificationList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务类目信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_info")]
        [System.Text.Json.Serialization.JsonPropertyName("category_info")]
        public IList<Types.CategoryInfo> CategoryInfoList { get; set; } = new List<Types.CategoryInfo>();
    }
}
