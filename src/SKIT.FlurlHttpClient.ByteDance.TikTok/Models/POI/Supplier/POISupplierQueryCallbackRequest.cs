namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/supplier/query_callback 接口的请求。</para>
    /// </summary>
    public class POISupplierQueryCallbackRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TaskId { get; set; } = string.Empty;
    }
}
