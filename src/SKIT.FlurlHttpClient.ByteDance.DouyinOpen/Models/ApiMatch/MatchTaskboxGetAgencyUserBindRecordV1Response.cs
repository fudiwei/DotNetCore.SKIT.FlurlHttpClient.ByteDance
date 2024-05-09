namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v1/taskbox/get_agency_user_bind_record/ 接口的响应。</para>
    /// </summary>
    public class MatchTaskboxGetAgencyUserBindRecordV1Response : DouyinOpenResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置团长 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("agent_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
                        public long AgentId { get; set; }

                        /// <summary>
                        /// 获取或设置达人抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("douyin_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("douyin_id")]
                        public string DouyinId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置机构侧达人 UID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("agency_talent_uid")]
                        [System.Text.Json.Serialization.JsonPropertyName("agency_talent_uid")]
                        public string? AgencyTalentUID { get; set; }

                        /// <summary>
                        /// 获取或设置绑定时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bind_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("bind_time")]
                        public long BindTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置解绑时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unbind_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("unbind_time")]
                        public long UnbindTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("results")]
                [System.Text.Json.Serialization.JsonPropertyName("results")]
                public Types.Result[] ResultList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }
            }
        }

        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int ErrorNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string? LogId { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0;
        }
    }
}
