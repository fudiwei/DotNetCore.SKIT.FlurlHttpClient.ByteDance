namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/poi/user 接口的请求。</para>
    /// </summary>
    public class DataExternalPOIUserRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置 POI ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string POIId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置日期类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int DateType { get; set; }
    }
}
