using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/add_ad_placement 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-29 下线。")]
    public class AppsCapacityAddAdPlacementV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置广告位名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_placement_name")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_placement_name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告位类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_placement_type")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_placement_type")]
        public int Type { get; set; }
    }
}
