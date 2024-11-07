namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/product/v1/app_region_add/ 接口的响应。</para>
    /// </summary>
    public class ProductAppRegionAddV1Response : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置绑定数据的唯一记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_id")]
        [System.Text.Json.Serialization.JsonPropertyName("data_id")]
        public string DataId { get; set; } = default!;
    }
}
