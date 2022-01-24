/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/advertiser/fund/daily_stat 接口的请求。</para>
    /// </summary>
    public class AdvertiserFundDailyStatisticsRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置开始日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_date")]
        [System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public string? StartDateString { get; set; }

        /// <summary>
        /// 获取或设置结束日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string? EndDateString { get; set; }

        /// <summary>
        /// 获取或设置分页页码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }
    }
}
