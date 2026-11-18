namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    public abstract class AppsStorageRequestBase : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置会话密钥。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? SessionKey { get; set; }

        /// <summary>
        /// 获取或设置签名方式。
        /// <para>默认值："hmac_sha256"</para>
        /// <remarks><i>（使用默认值即可，无需修改）</i></remarks>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? SignMethod { get; set; }

        /// <summary>
        /// 获取或设置请求签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? Signature { get; set; }
    }
}
