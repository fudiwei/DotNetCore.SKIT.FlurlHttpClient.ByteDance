namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/poi/supplier/query/match_task 接口的响应。</para>
    /// </summary>
    public class OpenApiThirdPartyPOISupplierQueryMatchTaskV1Response : DouyinMicroAppOpenApiLegacyResponseBase
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
                        /// 获取或设置 POI 名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_name")]
                        public string POIName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置外部商铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
                        public string SupplierExternalId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string Province { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string City { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string Address { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置其他信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extra")]
                        [System.Text.Json.Serialization.JsonPropertyName("extra")]
                        public string? Extra { get; set; }

                        /// <summary>
                        /// 获取或设置匹配状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("match_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("match_status")]
                        public int MatchStatus { get; set; }

                        /// <summary>
                        /// 获取或设置不匹配状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mismatch_status_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("mismatch_status_desc")]
                        public string? MismatchDescription { get; set; }
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
