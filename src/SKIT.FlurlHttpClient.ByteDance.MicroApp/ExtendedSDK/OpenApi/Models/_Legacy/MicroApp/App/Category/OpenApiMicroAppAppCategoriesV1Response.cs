namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/app/categories 接口的响应。</para>
    /// </summary>
    public class OpenApiMicroAppAppCategoriesV1Response : OpenApiLegacyResponseBase
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
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int Id { get; set; }

                                /// <summary>
                                /// 获取或设置资质名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置资质文件路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("path")]
                                [System.Text.Json.Serialization.JsonPropertyName("path")]
                                public string FilePath { get; set; } = default!;
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
                        [Newtonsoft.Json.JsonProperty("categoryName")]
                        [System.Text.Json.Serialization.JsonPropertyName("categoryName")]
                        public string CategoryNameString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务类目资质 ID 字符串（以逗号分隔）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categoryCertIds")]
                        [System.Text.Json.Serialization.JsonPropertyName("categoryCertIds")]
                        public string CertificationIdString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务类目资质信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categoryCert")]
                        [System.Text.Json.Serialization.JsonPropertyName("categoryCert")]
                        public Types.Certification[] CertificationList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categoryAuditState")]
                        [System.Text.Json.Serialization.JsonPropertyName("categoryAuditState")]
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
                [Newtonsoft.Json.JsonProperty("appCategoryAuditInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("appCategoryAuditInfo")]
                public Types.CategoryAuditInfo[] CategoryAuditInfoList { get; set; } = default!;

                /// <summary>
                /// 获取或设置剩余修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remainingTimes")]
                [System.Text.Json.Serialization.JsonPropertyName("remainingTimes")]
                public int RemainingTimes { get; set; }

                /// <summary>
                /// 获取或设置本月总共可以修改次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("categoryChangeLimit")]
                [System.Text.Json.Serialization.JsonPropertyName("categoryChangeLimit")]
                public int CategoryChangeLimit { get; set; }

                /// <summary>
                /// 获取或设置最多可以设置的服务类目数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("categoryLimit")]
                [System.Text.Json.Serialization.JsonPropertyName("categoryLimit")]
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
