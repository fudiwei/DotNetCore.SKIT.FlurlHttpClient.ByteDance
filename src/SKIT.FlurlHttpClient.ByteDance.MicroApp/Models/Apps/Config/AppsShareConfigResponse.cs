using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/share_config 接口的响应。</para>
    /// </summary>
    public class AppsShareConfigResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// 获取或设置返回的数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }
    }
}
