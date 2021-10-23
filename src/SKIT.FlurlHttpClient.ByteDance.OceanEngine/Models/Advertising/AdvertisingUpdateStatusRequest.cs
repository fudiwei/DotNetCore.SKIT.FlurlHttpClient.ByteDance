using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/ad/update/status 接口的请求。</para>
    /// </summary>
    public class AdvertisingUpdateStatusRequest : OceanEngineRequest
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

        /// <summary>
        /// 获取或设置操作状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opt_status")]
        [System.Text.Json.Serialization.JsonPropertyName("opt_status")]
        public string Operation { get; set; } = string.Empty;
    }
}
