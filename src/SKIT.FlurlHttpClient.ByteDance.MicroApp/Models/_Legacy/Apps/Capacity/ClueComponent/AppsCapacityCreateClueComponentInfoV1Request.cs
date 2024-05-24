using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/capacity/create_clue_component_info 接口的请求。</para>
    /// </summary>
    public class AppsCapacityCreateClueComponentInfoV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置线索组件名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config_name")]
        [System.Text.Json.Serialization.JsonPropertyName("config_name")]
        public string ConfigName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置地区编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region")]
        [System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 获取或设置地区编号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_list")]
        [System.Text.Json.Serialization.JsonPropertyName("region_list")]
        public IList<string>? RegionList { get; set; }

        /// <summary>
        /// 获取或设置服务类目 ID 字符串（以逗号分隔）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public string? CategoryIdString { get; set; }
    }
}
