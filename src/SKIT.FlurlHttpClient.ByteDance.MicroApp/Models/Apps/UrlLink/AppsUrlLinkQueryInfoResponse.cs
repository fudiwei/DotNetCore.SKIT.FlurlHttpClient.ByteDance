namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/url_link/query_info 接口的响应。</para>
    /// </summary>
    public class AppsUrlLinkQueryInfoResponse : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class UrlLinkInfo
            {
                /// <summary>
                /// 获取或设置小程序的 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ma_app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ma_app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置分享链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url_link")]
                [System.Text.Json.Serialization.JsonPropertyName("url_link")]
                public string UrlLink { get; set; } = default!;

                /// <summary>
                /// 获取或设置宿主名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_name")]
                [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                public string AppName { get; set; } = default!;

                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string? PagePath { get; set; }

                /// <summary>
                /// 获取或设置页面查询参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string? QueryString { get; set; }

                /// <summary>
                /// 获取或设置生成时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置失效时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long ExpireTimestamp { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置分享链接信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_link_info")]
        [System.Text.Json.Serialization.JsonPropertyName("url_link_info")]
        public Types.UrlLinkInfo UrlLinkInfo { get; set; } = default!;
    }
}
