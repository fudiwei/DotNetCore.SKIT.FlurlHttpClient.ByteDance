using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/v1/microapp/app/supply_categories 接口的请求。</para>
    /// </summary>
    public class OpenApiV1MicroAppAppSupplyCategoriesRequest : ByteDanceMicroAppRequest
    {
        public static class Types
        {
            public class CategoryInfo : OpenApiV1MicroAppAppAddCategoriesRequest.Types.CategoryInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置第三方应用 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置服务类目信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categoryInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("categoryInfo")]
        public IList<Types.CategoryInfo> CategoryInfoList { get; set; } = new List<Types.CategoryInfo>();
    }
}
