namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/spu/stock_update 接口的请求。</para>
    /// </summary>
    public class POISPUStockUpdateV2Request : TikTokRequest
    {
        /// <summary>
        /// 获取或设置 SPU 外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id")]
        public string SPUExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置库存数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock")]
        [System.Text.Json.Serialization.JsonPropertyName("stock")]
        public int Stock { get; set; }
    }
}
