namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/creative/create_v2 接口的响应。</para>
    /// </summary>
    public class CreativeCreateV2Response : OceanEngineResponse<CreativeCreateV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Creative
                    {
                        /// <summary>
                        /// 获取或设置创意 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("creative_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("creative_id")]
                        public long? CreativeId { get; set; }

                        /// <summary>
                        /// 获取或设置素材类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_mode")]
                        public string ImageMode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创意标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string CreativeTitle { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置第三方 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_party_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_party_id")]
                        public string ThirdPartyId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置广告主 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("advertiser_id")]
                [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                public long AdvertiserId { get; set; }

                /// <summary>
                /// 获取或设置广告计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                public long advertisingId { get; set; }

                /// <summary>
                /// 获取或设置创意 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creative_id")]
                [System.Text.Json.Serialization.JsonPropertyName("creative_id")]
                public long CreativeId { get; set; }

                /// <summary>
                /// 获取或设置修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_time")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
                public long ModifyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置自定义素材列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creatives")]
                [System.Text.Json.Serialization.JsonPropertyName("creatives")]
                public Types.Creative[] CreativeList { get; set; } = default!;
            }
        }
    }
}
