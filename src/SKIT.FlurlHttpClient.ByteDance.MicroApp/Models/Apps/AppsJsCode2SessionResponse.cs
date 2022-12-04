using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/jscode2session 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-01-05 下线。")]
    public class AppsJsCode2SessionResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// 获取或设置错误号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public int ErrorNumber { get; set; }

        /// <summary>
        /// 获取或设置会话密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("session_key")]
        [System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string? SessionKey { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置匿名用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anonymous_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("anonymous_openid")]
        public string? AnonymousOpenId { get; set; }

        /// <summary>
        /// 获取或设置用户的 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ErrorNumber == 0;
        }
    }
}
