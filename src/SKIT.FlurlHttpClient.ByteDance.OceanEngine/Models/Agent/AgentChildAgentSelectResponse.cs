namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/agent/child_agent/select 接口的响应。</para>
    /// </summary>
    public class AgentChildAgentSelectResponse : OceanEngineResponse<AgentChildAgentSelectResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置二级代理商 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("child_agent_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("child_agent_ids")]
                public long[] ChildAgentIdList { get; set; } = default!;
            }
        }
    }
}
