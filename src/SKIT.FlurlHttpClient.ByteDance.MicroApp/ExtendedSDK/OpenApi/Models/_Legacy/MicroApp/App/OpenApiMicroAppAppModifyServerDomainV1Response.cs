namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/modify_server_domain 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-23 下线。")]
    public class OpenApiMicroAppAppModifyServerDomainV1Response : DouyinMicroAppOpenApiLegacyResponseBase
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置 HTTP 域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request")]
                [System.Text.Json.Serialization.JsonPropertyName("request")]
                public List<string>? RequestDomainList { get; set; }

                /// <summary>
                /// 获取或设置 WebSocket 域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("socket")]
                [System.Text.Json.Serialization.JsonPropertyName("socket")]
                public List<string>? SocketDomainList { get; set; }

                /// <summary>
                /// 获取或设置上传域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload")]
                [System.Text.Json.Serialization.JsonPropertyName("upload")]
                public List<string>? UploadDomainList { get; set; }

                /// <summary>
                /// 获取或设置下载域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("download")]
                [System.Text.Json.Serialization.JsonPropertyName("download")]
                public List<string>? DownloadDomainList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data? Data { get; set; }
    }
}
