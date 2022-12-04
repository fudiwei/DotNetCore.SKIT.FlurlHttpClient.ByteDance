using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/token 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-01-05 下线。")]
    public class AppsTokenResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// 获取或设置错误号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public int ErrorNumber { get; set; }

        /// <summary>
        /// 获取或设置调用接口的凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string AccessToken { get; set; } = default!;

        /// <summary>
        /// 获取或设置凭证有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ErrorNumber == 0;
        }
    }
}
