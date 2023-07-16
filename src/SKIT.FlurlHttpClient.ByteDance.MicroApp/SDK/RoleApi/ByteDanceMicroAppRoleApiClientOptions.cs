namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi
{
    /// <summary>
    /// 一个用于构造 <see cref="ByteDanceMicroAppRoleApiClient"/> 时使用的配置项。
    /// </summary>
    public class ByteDanceMicroAppRoleApiClientOptions
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。
        /// <para>默认值：30000</para>
        /// </summary>
        public int Timeout { get; set; } = 30 * 1000;

        /// <summary>
        /// 获取或设置字节小程序泛知识角色系统 API 域名。
        /// <para>默认值：<see cref="ByteDanceMicroAppRoleApiEndpoints.DEFAULT"/></para>
        /// </summary>
        public string Endpoints { get; set; } = ByteDanceMicroAppRoleApiEndpoints.DEFAULT;

        /// <summary>
        /// 获取或设置字节小程序 AppId。
        /// </summary>
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置字节小程序 AppSecret。
        /// </summary>
        public string AppSecret { get; set; } = default!;
    }
}
