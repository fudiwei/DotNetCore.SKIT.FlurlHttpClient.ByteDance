namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    /// <summary>
    /// 一个用于构造 <see cref="DouyinMicroAppWebcastClient"/> 时使用的配置项。
    /// </summary>
    public class DouyinMicroAppWebcastClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置抖音小程序直播小玩法 API 入口点。
        /// <para>默认值：<see cref="DouyinMicroAppWebcastEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoint { get; set; } = DouyinMicroAppWebcastEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置抖音小程序 AppId。
        /// </summary>
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖音小程序 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖音小程序应用公钥版本号。
        /// <para>默认值："1"</para>
        /// </summary>
        public string ApplicationPublicKeyVersion { get; set; } = "1";

        /// <summary>
        /// 获取或设置抖音小程序应用私钥。
        /// </summary>
        public string ApplicationPrivateKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置抖音小程序平台公钥。
        /// </summary>
        public string PlatformPublicKey { get; set; } = default!;
    }
}
