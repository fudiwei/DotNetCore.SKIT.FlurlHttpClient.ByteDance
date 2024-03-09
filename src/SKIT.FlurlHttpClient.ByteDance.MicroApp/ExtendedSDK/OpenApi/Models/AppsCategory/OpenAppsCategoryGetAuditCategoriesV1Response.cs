namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/category/get_audit_categories 接口的响应。</para>
    /// </summary>
    public class OpenAppsCategoryGetAuditCategoriesV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CategoryAuditInfo
                    {
                        public static class Types
                        {
                            public class Certification
                            {
                                /// <summary>
                                /// 获取或设置资质 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string Id { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置资质名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置资质文件路径列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("path_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("path_list")]
                                public string[]? FilePathList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置服务类目 ID 字符串（以逗号分隔）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category")]
                        [System.Text.Json.Serialization.JsonPropertyName("category")]
                        public string CategoryIdString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务类目名称字符串（以短横线分隔）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                        public string CategoryNameString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务类目资质 ID 字符串（以逗号分隔）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_cert_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_cert_ids")]
                        public string CertificationIdString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务类目资质信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_cert")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_cert")]
                        public Types.Certification[] CertificationList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_audit_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_audit_state")]
                        public int AuditState { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置服务类目审核信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_category_audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("app_category_audit_info")]
                public Types.CategoryAuditInfo[] CategoryAuditInfoList { get; set; } = default!;

                /// <summary>
                /// 获取或设置剩余修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remaining_times")]
                [System.Text.Json.Serialization.JsonPropertyName("remaining_times")]
                public int RemainingTimes { get; set; }

                /// <summary>
                /// 获取或设置本月总共可以修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_change_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("category_change_limit")]
                public int CategoryChangeLimit { get; set; }

                /// <summary>
                /// 获取或设置最多可以设置的服务类目数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("category_limit")]
                public int CategoryTotalLimit { get; set; }
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
