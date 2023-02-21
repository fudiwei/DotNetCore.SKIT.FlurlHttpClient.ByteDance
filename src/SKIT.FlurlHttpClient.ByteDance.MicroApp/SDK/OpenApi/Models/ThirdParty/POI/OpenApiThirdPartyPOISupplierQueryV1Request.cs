namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/poi/supplier/query 接口的请求。</para>
    /// </summary>
    public class OpenApiThirdPartyPOISupplierQueryV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置外部商铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SupplierExternalId { get; set; } = string.Empty;
    }
}
