namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/poi/supplier/query/match 接口的响应。</para>
    /// </summary>
    public class OpenApiThirdPartyPOISupplierQueryMatchV1Response : ByteDanceMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class MatchResult
                    {
                        /// <summary>
                        /// 获取或设置抖音 POI ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string? POIId { get; set; }

                        /// <summary>
                        /// 获取或设置匹配任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        public string TaskId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置外部商铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
                        public string SupplierExternalId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置匹配状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int MatchStatus { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置匹配任务结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("match_result_list")]
                [System.Text.Json.Serialization.JsonPropertyName("match_result_list")]
                public Types.MatchResult[] MatchResultList { get; set; } = default!;
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
