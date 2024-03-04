namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/adlib/advertiser/query/ 接口的响应。</para>
    /// </summary>
    public class ResearchAdlibAdvertiserQueryResponse : TikTokV2Response<ResearchAdlibAdvertiserQueryResponse.Types.Data>
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
                        [Newtonsoft.Json.JsonProperty("business_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long BusinessId { get; set; }

                        /// <summary>
                        /// 获取或设置广告主名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_name")]
                        public string BusinessName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置国家代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("country_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("country_code")]
                        public string CountryCode { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置广告主列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("advertisers")]
                [System.Text.Json.Serialization.JsonPropertyName("advertisers")]
                public Types.Advertiser[] AdvertiserList { get; set; } = default!;
            }
        }
    }
}
