namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /spu/getSpuInfoBySpuId 接口的请求。</para>
    /// </summary>
    public class SPUGetSPUInformationBySPUIdRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置 SPU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_id")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
        public long SPUId { get; set; }
    }
}
