/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/majordomo/advertiser/select 接口的请求。</para>
    /// </summary>
    public class MajordomoAdvertiserSelectRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置账户管家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }
    }
}
