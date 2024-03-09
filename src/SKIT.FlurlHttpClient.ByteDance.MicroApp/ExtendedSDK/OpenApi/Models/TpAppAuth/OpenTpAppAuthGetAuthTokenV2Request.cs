namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /tpapp/v2/auth/get_auth_token 接口的请求。</para>
    /// </summary>
    public class OpenTpAppAuthGetAuthTokenV2Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置授权码。与字段 <see cref="AuthorizerRefreshToken"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AuthorizationCode { get; set; }

        /// <summary>
        /// 获取或设置授权方刷新令牌。与字段 <see cref="AuthorizationCode"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AuthorizerRefreshToken { get; set; }

        /// <summary>
        /// 获取或设置授权方式。
        /// <para>默认值："app_to_tp_authorization_code"</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GrantType { get; set; } = "app_to_tp_authorization_code";
    }
}
