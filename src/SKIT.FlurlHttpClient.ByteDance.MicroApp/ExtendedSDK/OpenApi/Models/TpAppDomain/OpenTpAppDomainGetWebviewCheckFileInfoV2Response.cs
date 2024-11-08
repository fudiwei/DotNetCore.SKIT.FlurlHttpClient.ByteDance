namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /tpapp/v2/doamin/get_webview_check_file_info/ 接口的响应。</para>
    /// </summary>
    public class OpenTpAppDomainGetWebviewCheckFileInfoV2Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置文件名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_name")]
                [System.Text.Json.Serialization.JsonPropertyName("file_name")]
                public string FileName { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_content")]
                [System.Text.Json.Serialization.JsonPropertyName("file_content")]
                public string FileContent { get; set; } = default!;
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
