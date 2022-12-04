namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/v2/supplier/query/task 接口的响应。</para>
    /// </summary>
    public class POISupplierQueryTaskV2Response : DouyinOpenResponse<POISupplierQueryTaskV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class MatchResult
                    {
                        /// <summary>
                        /// 获取或设置 POI ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string? POIId { get; set; }

                        /// <summary>
                        /// 获取或设置 POI 名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_name")]
                        public string? POIName { get; set; }

                        /// <summary>
                        /// 获取或设置接入方店铺外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
                        public string? SupplierExternalId { get; set; }

                        /// <summary>
                        /// 获取或设置所在省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string? Province { get; set; }

                        /// <summary>
                        /// 获取或设置所在城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string? City { get; set; }

                        /// <summary>
                        /// 获取或设置地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string? Address { get; set; }

                        /// <summary>
                        /// 获取或设置扩展信息。
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
                        /// 获取或设置匹配状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mismatch_status_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("mismatch_status_desc")]
                        public string MatchStatusDescription { get; set; } = default!;
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
