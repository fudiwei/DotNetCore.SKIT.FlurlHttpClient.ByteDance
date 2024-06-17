using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/package/audit_hosts 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-21 下线。")]
    public class OpenApiMicroAppPackageAuditHostsV1Response : DouyinMicroAppOpenApiLegacyResponseBase
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置本次审核可选宿主端英文简称列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hostNames")]
                [System.Text.Json.Serialization.JsonPropertyName("hostNames")]
                public string[] HostNames { get; set; } = default!;

                /// <summary>
                /// 获取或设置上次发布的宿主端英文简称列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("releasedHostNames")]
                [System.Text.Json.Serialization.JsonPropertyName("releasedHostNames")]
                public string[] ReleasedHostNames { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
