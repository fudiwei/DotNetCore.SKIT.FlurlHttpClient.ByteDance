namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    public abstract class AppsECPayRequestBase : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置请求签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public virtual string? Signature { get; set; }
    }
}
