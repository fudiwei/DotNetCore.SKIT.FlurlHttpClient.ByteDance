namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/poi/match/task/query 接口的响应。</para>
    /// </summary>
    public class GoodLifePOIMatchTaskQueryV1Response : DouyinOpenResponse<GoodLifePOIMatchTaskQueryV1Response.Types.Data>
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
                        /// 获取或设置门店外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ext_id")]
                        public string POIExternalId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 POI ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("match_poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("match_poi_id")]
                        public string? POIId { get; set; }

                        /// <summary>
                        /// 获取或设置匹配状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("match_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("match_status")]
                        public int MatchStatus { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置匹配结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("results")]
                [System.Text.Json.Serialization.JsonPropertyName("results")]
                public Types.MatchResult[] MatchResultList { get; set; } = default!;
            }
        }
    }
}
