namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/token 接口的请求。</para>
    /// </summary>
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
