using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/developer_toolbox/image_material/function_config/add/ 接口的请求。</para>
    /// </summary>
    public class AppsDeveloperToolboxImageMaterialFunctionConfigAddV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置功能配置列表字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_function_config")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_function_config")]
        public IDictionary<string, IList<string>> SceneFunctionConfigMap { get; set; } = new Dictionary<string, IList<string>>();
    }
}
