namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/v2/supplier/query/supplier 接口的响应。</para>
    /// </summary>
    public class POISupplierQuerySupplierV2Response : DouyinOpenResponse<POISupplierQuerySupplierV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class MatchResult
                    {
                        /// <summary>
                        /// 获取或设置任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        public string? TaskId { get; set; }

                        /// <summary>
                        /// 获取或设置 POI ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string? POIId { get; set; }

                        /// <summary>
                        /// 获取或设置门店外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
                        public string? SupplierExternalId { get; set; }

                        /// <summary>
                        /// 获取或设置匹配状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int MatchStatus { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置匹配结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("match_result_list")]
                [System.Text.Json.Serialization.JsonPropertyName("match_result_list")]
                public Types.MatchResult[] MatchResultList { get; set; } = default!;
            }
        }
    }
}
