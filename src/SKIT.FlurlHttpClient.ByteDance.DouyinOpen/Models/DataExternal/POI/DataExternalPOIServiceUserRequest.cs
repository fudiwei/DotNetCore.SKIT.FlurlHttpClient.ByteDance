namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/poi/service_user 接口的请求。</para>
    /// </summary>
    public class DataExternalPOIServiceUserRequest : DataExternalPOIUserRequest
    {
        /// <summary>
        /// 获取或设置服务类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? ServiceType { get; set; }
    }
}
