namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_alias_list 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryAliasListV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class AliasItem
                    {
                        /// <summary>
                        /// 获取或设置小程序别名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("alias")]
                        [System.Text.Json.Serialization.JsonPropertyName("alias")]
                        public string Alias { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                        public int AuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ctime")]
                        [System.Text.Json.Serialization.JsonPropertyName("ctime")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("utime")]
                        [System.Text.Json.Serialization.JsonPropertyName("utime")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置本周还剩余修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("week_available_times")]
                [System.Text.Json.Serialization.JsonPropertyName("week_available_times")]
                public int WeekAvailableTimes { get; set; }

                /// <summary>
                /// 获取或设置每周总共可修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("week_total_times")]
                [System.Text.Json.Serialization.JsonPropertyName("week_total_times")]
                public int WeekTotalTimes { get; set; }

                /// <summary>
                /// 获取或设置别名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("alias_list")]
                [System.Text.Json.Serialization.JsonPropertyName("alias_list")]
                public Types.AliasItem[] AliasList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
