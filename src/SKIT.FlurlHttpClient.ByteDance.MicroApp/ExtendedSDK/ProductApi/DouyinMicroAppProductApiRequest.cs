namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi
{
    /// <summary>
    /// 抖音小程序泛知识课程库 API 请求的基类。
    /// </summary>
    public abstract class DouyinMicroAppProductApiRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置抖音小程序的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppProductApiClient"/> 时的 <see cref="DouyinMicroAppProductApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public virtual string? AppId { get; set; }

        /// <summary>
        /// 获取或设置抖音小程序的 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public virtual string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置沙盒环境自动审核参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? SandboxCheckType { get; set; }
    }
}
