namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/poi/billboard 接口的请求。</para>
    /// </summary>
    public class DataExternalPOIBillboardRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置热度榜类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int BillboardType { get; set; }
    }
}
