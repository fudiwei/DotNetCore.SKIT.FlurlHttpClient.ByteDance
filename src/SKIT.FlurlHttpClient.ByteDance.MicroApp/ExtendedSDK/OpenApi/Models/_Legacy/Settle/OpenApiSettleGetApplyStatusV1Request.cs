namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/settle/get_apply_status 接口的请求。</para>
    /// </summary>
    public class OpenApiSettleGetApplyStatusV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置申请请求 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ApplyId { get; set; } = string.Empty;
    }
}
