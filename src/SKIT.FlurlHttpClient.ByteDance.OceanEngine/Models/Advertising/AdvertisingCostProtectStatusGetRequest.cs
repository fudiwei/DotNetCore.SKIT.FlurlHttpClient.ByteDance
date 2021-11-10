using System.Collections.Generic;

/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/ad/cost_protect_status/get 接口的请求。</para>
    /// </summary>
    public class AdvertisingCostProtectStatusGetRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置广告计划 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_ids")]
        public IList<long> AdvertisingIdList { get; set; } = new List<long>();
    }
}
