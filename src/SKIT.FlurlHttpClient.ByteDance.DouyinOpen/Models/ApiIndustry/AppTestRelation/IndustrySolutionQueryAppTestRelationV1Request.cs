namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/industry/v1/solution/query_app_test_relation 接口的请求。</para>
    /// </summary>
    public class IndustrySolutionQueryAppTestRelationV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置测试物料类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}
