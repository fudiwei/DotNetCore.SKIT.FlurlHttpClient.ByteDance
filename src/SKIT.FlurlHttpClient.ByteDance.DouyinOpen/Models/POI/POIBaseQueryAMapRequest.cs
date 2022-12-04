namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/base/query/amap 接口的请求。</para>
    /// </summary>
    public class POIBaseQueryAMapRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置高德地图 POI ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AMapId { get; set; } = string.Empty;
    }
}
