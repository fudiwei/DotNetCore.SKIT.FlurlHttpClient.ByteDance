namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v1/taskbox/save_agent/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskboxSaveAgentV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置团长 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public long? AgentId { get; set; }

        /// <summary>
        /// 获取或设置团长昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("agent_nickname")]
        public string AgentNickname { get; set; } = string.Empty;
    }
}
