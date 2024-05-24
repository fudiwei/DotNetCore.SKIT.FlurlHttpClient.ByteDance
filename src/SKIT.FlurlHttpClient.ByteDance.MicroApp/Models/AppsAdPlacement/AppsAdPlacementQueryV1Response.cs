namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/ad_placement/query/ 接口的响应。</para>
    /// </summary>
    public class AppsAdPlacementQueryV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class AdPlacement
                    {
                        /// <summary>
                        /// 获取或设置广告位 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_placement_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_placement_id")]
                        public string AdPlacementId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置广告位名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_placement_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_placement_name")]
                        public string AdPlacementName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置广告位类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_placement_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_placement_type")]
                        public int AdPlacementType { get; set; }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置广告位列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_placement_list")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_placement_list")]
                public Types.AdPlacement[] AdPlacementList { get; set; } = default!;
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
