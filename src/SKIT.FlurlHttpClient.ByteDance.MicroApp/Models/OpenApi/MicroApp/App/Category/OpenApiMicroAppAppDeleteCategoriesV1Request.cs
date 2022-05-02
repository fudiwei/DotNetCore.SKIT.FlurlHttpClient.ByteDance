using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/v1/microapp/app/del_categories 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppAppDeleteCategoriesV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置第三方应用 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置服务类目 ID 字符串（以逗号分隔）列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories")]
        [System.Text.Json.Serialization.JsonPropertyName("categories")]
        public IList<string> CategoryIdStringList { get; set; } = new List<string>();
    }
}
