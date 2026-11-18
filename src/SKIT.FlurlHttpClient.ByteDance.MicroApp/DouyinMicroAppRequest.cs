namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 抖音小程序 API 请求的基类。
    /// </summary>
    public abstract class DouyinMicroAppRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置抖音小程序的 AccessToken/ClientToken/BusinessToken。
        /// </summary>
        /// <remarks>
        /// （注意：该属性在部分第三方平台的接口中表示授权方的 AuthorizerAccessToken。）
        /// </remarks>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }
    }
}
