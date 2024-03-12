using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/industry/v1/solution/add_app_test_relation 接口的请求。</para>
    /// </summary>
    public class IndustrySolutionAddAppTestRelationV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置请求操作人。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        [System.Text.Json.Serialization.JsonPropertyName("operator")]
        public string Operator { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置测试物料类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置物料 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ref_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ref_id_list")]
        public IList<string> ReferenceIdList { get; set; } = new List<string>();
    }
}
