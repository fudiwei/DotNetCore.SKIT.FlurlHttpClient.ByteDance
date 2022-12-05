namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/poi/match/relation/query 接口的响应。</para>
    /// </summary>
    public class GoodLifePOIMatchRelationQueryV1Response : DouyinOpenResponse<GoodLifePOIMatchRelationQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Relation
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
                        [Newtonsoft.Json.JsonProperty("match_relation_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("match_relation_status")]
                        public int MatchStatus { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置关联关系列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("relations")]
                [System.Text.Json.Serialization.JsonPropertyName("relations")]
                public Types.Relation[] RelationList { get; set; } = default!;
            }
        }
    }
}
