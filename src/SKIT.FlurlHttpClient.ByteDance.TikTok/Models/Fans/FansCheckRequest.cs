namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /fans/check 接口的请求。</para>
    /// </summary>
    public class FansCheckRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置粉丝用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FollowerOpenId { get; set; } = string.Empty;
    }
}
