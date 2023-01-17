namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_search_tag_list 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQuerySearchTagListV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class TagItem
                    {
                        /// <summary>
                        /// 获取或设置搜索标签。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("search_tag")]
                        [System.Text.Json.Serialization.JsonPropertyName("search_tag")]
                        public string Tag { get; set; } = default!;

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
                    }
                }

                /// <summary>
                /// 获取或设置本月还剩余修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("month_available_times")]
                [System.Text.Json.Serialization.JsonPropertyName("month_available_times")]
                public int MonthAvailableTimes { get; set; }

                /// <summary>
                /// 获取或设置每月总共可修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("month_total_times")]
                [System.Text.Json.Serialization.JsonPropertyName("month_total_times")]
                public int MonthTotalTimes { get; set; }

                /// <summary>
                /// 获取或设置搜索标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("search_tag_list")]
                [System.Text.Json.Serialization.JsonPropertyName("search_tag_list")]
                public Types.TagItem[] TagList { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
