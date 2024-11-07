namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/product/v1/app_region_modify/ 接口的请求。</para>
    /// </summary>
    public class ProductAppRegionModifyV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置原关联地区编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("origin_region")]
        [System.Text.Json.Serialization.JsonPropertyName("origin_region")]
        public string OriginRegionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新关联地区编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_region")]
        [System.Text.Json.Serialization.JsonPropertyName("current_region")]
        public string CurrentRegionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? PagePath { get; set; }
    }
}
