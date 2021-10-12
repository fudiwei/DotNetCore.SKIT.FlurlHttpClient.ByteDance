namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/supplier/query 接口的请求。</para>
    /// </summary>
    public class POISupplierQueryRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置接入方店铺外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ExternalSupplierId { get; set; } = string.Empty;
    }
}
