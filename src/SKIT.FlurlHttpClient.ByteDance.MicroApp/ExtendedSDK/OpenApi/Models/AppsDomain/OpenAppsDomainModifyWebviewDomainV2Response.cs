namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v2/domain/modify_webview_domain 接口的响应。</para>
    /// </summary>
    public class OpenAppsDomainModifyWebviewDomainV2Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置 Webview 域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("webview")]
                [System.Text.Json.Serialization.JsonPropertyName("webview")]
                public string[]? WebviewDomainList { get; set; }
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
