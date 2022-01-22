namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    /// <summary>
    /// 巨量引擎开放平台 API 请求的基类。
    /// </summary>
    public abstract class OceanEngineRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="OceanEngineClient"/> 时的 <see cref="OceanEngineClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

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
