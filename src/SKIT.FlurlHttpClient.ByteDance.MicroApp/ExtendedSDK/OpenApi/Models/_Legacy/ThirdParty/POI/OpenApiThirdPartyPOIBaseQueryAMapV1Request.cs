namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/poi/base/query/amap 接口的请求。</para>
    /// </summary>
    public class OpenApiThirdPartyPOIBaseQueryAMapV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置高德 POI ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AMapId { get; set; } = string.Empty;
    }
}
