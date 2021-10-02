namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /devtool/micapp/is_legal 接口的请求。</para>
    /// </summary>
    public class DevToolMicroAppIsLegalRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string MicroAppId { get; set; } = string.Empty;
    }
}
