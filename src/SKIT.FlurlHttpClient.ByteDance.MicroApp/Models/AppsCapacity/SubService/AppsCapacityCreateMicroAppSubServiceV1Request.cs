using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/create_ma_sub_service/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityCreateMicroAppSubServiceV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置检索关键词列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_key_word")]
        [System.Text.Json.Serialization.JsonPropertyName("search_key_word")]
        public IList<string> SearchKeywordList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置对应功能服务页面的路径链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_page_url")]
        [System.Text.Json.Serialization.JsonPropertyName("start_page_url")]
        public string StartPageUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置搜索直达子服务的名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_service_name")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_service_name")]
        public string SubServiceName { get; set; } = string.Empty;
    }
}
