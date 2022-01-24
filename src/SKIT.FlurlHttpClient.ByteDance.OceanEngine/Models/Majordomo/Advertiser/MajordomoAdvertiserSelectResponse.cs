namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/majordomo/advertiser/select 接口的响应。</para>
    /// </summary>
    public class MajordomoAdvertiserSelectResponse : OceanEngineResponse<MajordomoAdvertiserSelectResponse.Types.Data>
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
                        public long AdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置广告主名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_name")]
                        public string AdvertiserName { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置广告主列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Advertiser[] AdvertiserList { get; set; } = default!;
            }
        }
    }
}
