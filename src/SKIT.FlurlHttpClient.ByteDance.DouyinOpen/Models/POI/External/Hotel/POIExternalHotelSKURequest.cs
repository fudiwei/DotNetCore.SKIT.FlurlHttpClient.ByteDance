namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/ext/hotel/sku 接口的请求。</para>
    /// </summary>
    public class POIExternalHotelSKURequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置 SPU 外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SPUExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置拉取价格时间区间开始时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StartDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置拉取价格时间区间结束时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EndDateString { get; set; } = string.Empty;
    }
}
