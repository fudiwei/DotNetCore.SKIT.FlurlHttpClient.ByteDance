using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/industry/v1/solution/query_impl 接口的请求。</para>
    /// </summary>
    public class IndustrySolutionQueryImplementationV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置解决方案 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("solution_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("solution_id_list")]
        public IList<string> SolutionIdList { get; set; } = new List<string>();
    }
}
