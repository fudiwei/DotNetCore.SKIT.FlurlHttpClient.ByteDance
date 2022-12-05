namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/logisticsEditByPack 接口的请求。</para>
    /// </summary>
    public class OrderLogisticsEditByPackageRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置包裹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pack_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pack_id")]
        public string PackageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
        public string LogisticsNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置物流公司 ID。与字段 <see cref="CompanyCode"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_id")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_id")]
        public int? CompanyId { get; set; }

        /// <summary>
        /// 获取或设置物流公司编码。与字段 <see cref="CompanyId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_code")]
        [System.Text.Json.Serialization.JsonPropertyName("company_code")]
        public string? CompanyCode { get; set; }
    }
}
