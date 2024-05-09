namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v1/taskbox/gen_agent_link/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskboxGenerateAgentLinkV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置团长 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public long AgentId { get; set; }

        /// <summary>
        /// 获取或设置机构侧达人 UID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agency_talent_uid")]
        [System.Text.Json.Serialization.JsonPropertyName("agency_talent_uid")]
        public string? AgencyTalentUID { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long? TaskId { get; set; }
    }
}
