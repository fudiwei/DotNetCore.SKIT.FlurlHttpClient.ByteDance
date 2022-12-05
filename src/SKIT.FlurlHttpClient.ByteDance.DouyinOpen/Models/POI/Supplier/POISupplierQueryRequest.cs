namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/supplier/query 接口的请求。</para>
    /// </summary>
    public class POISupplierQueryRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置门店外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ExternalSupplierId { get; set; } = string.Empty;
    }
}
