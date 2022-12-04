using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/token 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-01-05 下线。")]
    public class AppsTokenRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GrantType { get; set; } = "client_credential";
    }
}
