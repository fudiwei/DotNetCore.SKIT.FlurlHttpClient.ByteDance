using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/poi/supplier/query/match 接口的请求。</para>
    /// </summary>
    public class OpenApiThirdPartyPOISupplierQueryMatchV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置外部商铺 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> SupplierExternalIds { get; set; } = new List<string>();
    }
}
