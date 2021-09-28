namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /warehouse/create 接口的请求。</para>
    /// </summary>
    public class WarehouseCreateRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置外部仓库 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
        public string OutWarehouseId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置仓库名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置仓库介绍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intro")]
        [System.Text.Json.Serialization.JsonPropertyName("intro")]
        public string Introduction { get; set; } = string.Empty;
    }
}
