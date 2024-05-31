using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/toolkit/button_white_setting 接口的请求。</para>
    /// </summary>
    public class AppsTradeToolkitButtonWhiteSettingV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置按钮类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button_type")]
        [System.Text.Json.Serialization.JsonPropertyName("button_type")]
        public int ButtonType { get; set; }

        /// <summary>
        /// 获取或设置白名单。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("uid_list")]
        public IList<int>? Whitelist { get; set; }

        /// <summary>
        /// 获取或设置是否全量用户可见。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_all")]
        [System.Text.Json.Serialization.JsonPropertyName("open_all")]
        public bool? IsOpenAll { get; set; }
    }
}
