namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/agent/info 接口的请求。</para>
    /// </summary>
    public class AgentInfoRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置代理商 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_ids")]
        public List<long>? AgentIdList { get; set; }

        /// <summary>
        /// 获取或设置查询字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fields")]
        [System.Text.Json.Serialization.JsonPropertyName("fields")]
        public List<string>? FieldList { get; set; }
    }
}
