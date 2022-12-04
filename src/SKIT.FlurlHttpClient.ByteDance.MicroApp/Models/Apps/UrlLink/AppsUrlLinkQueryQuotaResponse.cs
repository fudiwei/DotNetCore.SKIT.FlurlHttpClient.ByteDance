namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/url_link/query_quota 接口的响应。</para>
    /// </summary>
    public class AppsUrlLinkQueryQuotaResponse : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class UrlLinkQuota
            {
                /// <summary>
                /// 获取或设置已生成次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url_link_used")]
                [System.Text.Json.Serialization.JsonPropertyName("url_link_used")]
                public int UsedCount { get; set; }

                /// <summary>
                /// 获取或设置次数上限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url_link_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("url_link_limit")]
                public int LimitCount { get; set; }
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
        /// 获取或设置分享配额息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_link_quota")]
        [System.Text.Json.Serialization.JsonPropertyName("url_link_quota")]
        public Types.UrlLinkQuota UrlLinkQuota { get; set; } = default!;
    }
}
