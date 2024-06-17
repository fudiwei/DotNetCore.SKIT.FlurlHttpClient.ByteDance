using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/developer_toolbox/image_material/function_config/query_status/ 接口的响应。</para>
    /// </summary>
    public class AppsDeveloperToolboxImageMaterialFunctionConfigQueryStatusV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置功能配置状态字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("function_config_status")]
                [System.Text.Json.Serialization.JsonPropertyName("function_config_status")]
                public IDictionary<string, int> FunctionConfigStatusMap { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
