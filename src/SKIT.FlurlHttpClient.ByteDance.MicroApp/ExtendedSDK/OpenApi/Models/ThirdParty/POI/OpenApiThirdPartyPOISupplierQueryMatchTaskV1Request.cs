using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/poi/supplier/query/match_task 接口的请求。</para>
    /// </summary>
    public class OpenApiThirdPartyPOISupplierQueryMatchTaskV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置匹配任务 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> TaskIdList { get; set; } = new List<string>();
    }
}
