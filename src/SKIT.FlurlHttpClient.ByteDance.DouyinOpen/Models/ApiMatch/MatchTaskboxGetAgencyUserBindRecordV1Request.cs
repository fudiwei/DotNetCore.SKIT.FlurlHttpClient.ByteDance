namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v1/taskbox/get_agency_user_bind_record/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskboxGetAgencyUserBindRecordV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_no")]
        [System.Text.Json.Serialization.JsonPropertyName("page_no")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置团长 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public long? AgentId { get; set; }

        /// <summary>
        /// 获取或设置达人抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("douyin_id")]
        [System.Text.Json.Serialization.JsonPropertyName("douyin_id")]
        public string? DouyinId { get; set; }

        /// <summary>
        /// 获取或设置机构侧达人 UID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agency_talent_uid")]
        [System.Text.Json.Serialization.JsonPropertyName("agency_talent_uid")]
        public string? AgencyTalentUID { get; set; }
    }
}
