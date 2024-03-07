namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 抖音小程序 API 请求的基类。
    /// </summary>
    public abstract class DouyinMicroAppRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置抖音小程序的 AccessToken/ClientToken/BusinessToken。
        /// <para>
        /// 注意：部分第三方平台的接口中该字段表示授权方的 AuthorizerAccessToken。
        /// </para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
