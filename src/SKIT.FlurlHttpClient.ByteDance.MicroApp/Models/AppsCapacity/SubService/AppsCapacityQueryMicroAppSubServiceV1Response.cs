namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/capacity/query_ma_sub_service/ 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryMicroAppSubServiceV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SubService
                    {
                        public static class Types
                        {
                            public class RejectReason
                            {
                                /// <summary>
                                /// 获取或设置审核拒绝标签。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("audit_field")]
                                [System.Text.Json.Serialization.JsonPropertyName("audit_field")]
                                public string AuditField { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置审核拒绝原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                                public string Reason { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置子服务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_service_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_service_id")]
                        public string SubServiceId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置子服务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_service_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_service_name")]
                        public string SubServiceName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("micro_app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("micro_app_id")]
                        public string MicroAppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序图标 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("micro_app_icon")]
                        [System.Text.Json.Serialization.JsonPropertyName("micro_app_icon")]
                        public string MicroAppIconUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置检索关键词列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("search_key_word")]
                        [System.Text.Json.Serialization.JsonPropertyName("search_key_word")]
                        public string[] SearchKeywordList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置对应功能服务页面的路径链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_page_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_page_url")]
                        public string StartPageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("approval_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("approval_state")]
                        public int ApprovalState { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reasons")]
                        [System.Text.Json.Serialization.JsonPropertyName("reasons")]
                        public Types.RejectReason[]? RejectReasonList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置搜索直达子服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ma_sub_service_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("ma_sub_service_info_list")]
                public Types.SubService[] SubServiceList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否还有更多数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
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
