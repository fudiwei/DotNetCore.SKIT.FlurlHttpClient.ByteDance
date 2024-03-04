namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    /// <summary>
    /// 巨量引擎开放平台 API 请求的基类。
    /// </summary>
    public abstract class OceanEngineRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置接口调用凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置是否开启调试模式。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual bool DebugMode { get; set; }
    }
}
