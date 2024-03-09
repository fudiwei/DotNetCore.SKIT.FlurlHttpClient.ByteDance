namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/package_version/get_audit_hosts/ 接口的响应。</para>
    /// </summary>
    public class OpenAppsPackageVersionGetAuditHostsV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置本次审核可选宿主端列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("host_names")]
                [System.Text.Json.Serialization.JsonPropertyName("host_names")]
                public string[] HostNames { get; set; } = default!;

                /// <summary>
                /// 获取或设置上次发布的宿主端列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("released_host_names")]
                [System.Text.Json.Serialization.JsonPropertyName("released_host_names")]
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
