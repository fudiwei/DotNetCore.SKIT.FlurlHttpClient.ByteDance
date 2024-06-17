namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/developer_toolbox/image_material/function_config/query_status/ 接口的请求。</para>
    /// </summary>
    public class AppsDeveloperToolboxImageMaterialFunctionConfigQueryStatusV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置功能 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FunctionId { get; set; } = string.Empty;
    }
}
