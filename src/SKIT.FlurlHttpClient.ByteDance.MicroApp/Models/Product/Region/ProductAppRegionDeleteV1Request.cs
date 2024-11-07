namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/product/v1/app_region_delete/ 接口的请求。</para>
    /// </summary>
    public class ProductAppRegionDeleteV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置关联地区编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_id")]
        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public string RegionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? PagePath { get; set; }
    }
}
