namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine
{
    /// <summary>
    /// 一个用于构造 <see cref="OceanEngineClient"/> 时使用的配置项。
    /// </summary>
    public class OceanEngineClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置巨量引擎开放平台 API 域名。
        /// <para>默认值：<see cref="OceanEngineEndpoints.DEFAULT"/></para>
        /// </summary>
        public string? Endpoints { get; set; }

        /// <summary>
        /// 获取或设置巨量引擎开放平台应用 ID。
        /// </summary>
        public long AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置巨量引擎开放平台应用密钥。
        /// </summary>
        public string AppSecret { get; set; } = default!;
    }
}
