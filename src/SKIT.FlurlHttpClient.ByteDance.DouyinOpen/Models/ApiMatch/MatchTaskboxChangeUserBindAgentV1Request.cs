namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v1/taskbox/change_user_bind_agent/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskboxChangeUserBindAgentV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置原团长 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("old_agent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("old_agent_id")]
        public long OldAgentId { get; set; }

        /// <summary>
        /// 获取或设置新团长 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_agent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("new_agent_id")]
        public long NewAgentId { get; set; }

        /// <summary>
        /// 获取或设置达人抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("douyin_id")]
        [System.Text.Json.Serialization.JsonPropertyName("douyin_id")]
        public string DouyinId { get; set; } = string.Empty;
    }
}
