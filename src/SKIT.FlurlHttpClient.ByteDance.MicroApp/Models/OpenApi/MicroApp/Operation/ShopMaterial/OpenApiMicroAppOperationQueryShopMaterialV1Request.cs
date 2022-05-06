namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /openapi/v1/microapp/operation/query_shop_material 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppOperationQueryShopMaterialV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置第三方应用 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置接入方店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SupplierExternalId { get; set; } = string.Empty;
    }
}
