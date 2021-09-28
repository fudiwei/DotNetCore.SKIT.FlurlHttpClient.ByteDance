namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /warehouse/info 接口的请求。</para>
    /// </summary>
    public class WarehouseInformationRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置外部仓库 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
        public string OutWarehouseId { get; set; } = string.Empty;
    }
}
