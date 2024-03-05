namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/operation/query_shop_material 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppOperationQueryShopMaterialV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置接入方店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SupplierExternalId { get; set; } = string.Empty;
    }
}
