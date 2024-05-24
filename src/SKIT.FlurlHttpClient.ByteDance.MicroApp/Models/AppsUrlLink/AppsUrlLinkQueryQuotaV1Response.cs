namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/url_link/query_quota 接口的响应。</para>
    /// </summary>
    public class AppsUrlLinkQueryQuotaV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
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
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
