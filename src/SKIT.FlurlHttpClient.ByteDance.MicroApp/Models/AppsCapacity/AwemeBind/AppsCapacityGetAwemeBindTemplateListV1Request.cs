using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/get_aweme_bind_template_list/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityGetAwemeBindTemplateListV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_id")]
        public string AwemeId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置绑定类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置绑定能力标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capacity_list")]
        [System.Text.Json.Serialization.JsonPropertyName("capacity_list")]
        public IList<string> CapacityKeyList { get; set; } = new List<string>();
    }
}
