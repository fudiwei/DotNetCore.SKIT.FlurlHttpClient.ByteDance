using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/supply_categories 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-23 下线。")]
    public class OpenApiMicroAppAppSupplyCategoriesV1Request : DouyinMicroAppOpenApiRequest
    {
        public static class Types
        {
            public class CategoryInfo : OpenApiMicroAppAppAddCategoriesV1Request.Types.CategoryInfo
            {
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
