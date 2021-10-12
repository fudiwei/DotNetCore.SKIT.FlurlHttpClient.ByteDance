namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/query 接口的请求。</para>
    /// </summary>
    public class POIQueryRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置高德地图 POI ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AMapId { get; set; } = string.Empty;
    }
}
