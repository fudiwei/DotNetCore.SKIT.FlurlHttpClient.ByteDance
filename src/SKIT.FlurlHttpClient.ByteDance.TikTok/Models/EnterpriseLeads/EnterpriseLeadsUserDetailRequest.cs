namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /enterprise/leads/user/detail 接口的请求。</para>
    /// </summary>
    public class EnterpriseLeadsUserDetailRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置意向用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UserOpenId { get; set; } = string.Empty;
    }
}
