namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/customer_center/advertiser/list 接口的响应。</para>
    /// </summary>
    public class CustomerCenterAdvertiserListResponse : OceanEngineResponse<CustomerCenterAdvertiserListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Advertiser
                    {
                        /// <summary>
                        /// 获取或设置广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                        public long? AdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置广告主名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_name")]
                        public string? AdvertiserName { get; set; }

                        /// <summary>
                        /// 获取或设置企业号 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("e_douyin_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("e_douyin_id")]
                        public string? EDouyinId { get; set; }

                        /// <summary>
                        /// 获取或设置企业号名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("e_douyin_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("e_douyin_name")]
                        public string? EDouyinName { get; set; }
                    }

                    public class Pagination : AgentAdvertiserSelectResponse.Types.Data.Types.Pagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置广告主列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Advertiser[] AdvertiserList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Types.Pagination Pagination { get; set; } = default!;
            }
        }
    }
}
