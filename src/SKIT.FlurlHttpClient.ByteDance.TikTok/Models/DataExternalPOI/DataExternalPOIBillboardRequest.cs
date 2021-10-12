namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/poi/billboard 接口的请求。</para>
    /// </summary>
    public class DataExternalPOIBillboardRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置热度榜类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int BillboardType { get; set; }
    }
}
