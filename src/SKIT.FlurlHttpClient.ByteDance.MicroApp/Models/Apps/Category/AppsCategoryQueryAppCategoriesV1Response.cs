namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/category/query_app_categories 接口的响应。</para>
    /// </summary>
    public class AppsCategoryQueryAppCategoriesV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class AppCategoryAuditInfo
                    {
                        public static class Types
                        {
                            public class Certificate
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
                                /// 获取或设置资质文件路径列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pathList")]
                                [System.Text.Json.Serialization.JsonPropertyName("pathList")]
                                public string[] FilePathList { get; set; } = default!;
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
                        /// 获取或设置服务类目资质 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categoryCertIds")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerArrayWithCommaSplitConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("categoryCertIds")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualIntegerArrayWithCommaSplitConverter))]
                        public int[] CertificationIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置本月剩余更改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categoryCert")]
                        [System.Text.Json.Serialization.JsonPropertyName("categoryCert")]
                        public Types.Certificate[] CertificationList { get; set; } = default!;

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
                /// 获取或设置本月剩余更改次数。
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
                public int CategoryLimit { get; set; }

                /// <summary>
                /// 获取或设置服务类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appCategoryAuditInfo")]
                [System.Text.Json.Serialization.JsonPropertyName("appCategoryAuditInfo")]
                public Types.AppCategoryAuditInfo[] AppCategoryAuditList { get; set; } = default!;
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
