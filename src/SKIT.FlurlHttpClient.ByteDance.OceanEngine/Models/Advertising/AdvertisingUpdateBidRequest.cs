using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/ad/update/bid 接口的请求。</para>
    /// </summary>
    public class AdvertisingUpdateBidRequest : OceanEngineRequest
    {
        public static class Types
        {
            public class AdBid
            {
                /// <summary>
                /// 获取或设置广告计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                public long AdvertisingId { get; set; }

                /// <summary>
                /// 获取或设置出价（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bid")]
                [System.Text.Json.Serialization.JsonPropertyName("bid")]
                public double Bid { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置广告计划出价列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IList<Types.AdBid> AdBidList { get; set; } = new List<Types.AdBid>();
    }
}
