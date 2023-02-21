namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/poi/base/query/amap 接口的请求。</para>
    /// </summary>
    public class OpenApiThirdPartyPOIBaseQueryAMapV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置高德 POI ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AMapId { get; set; } = string.Empty;
    }
}
