using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/jscode2session 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-01-05 下线。")]
    public class AppsJsCode2SessionRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置登录 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Code { get; set; }

        /// <summary>
        /// 获取或设置匿名登录 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AnoymousCode { get; set; }
    }
}
