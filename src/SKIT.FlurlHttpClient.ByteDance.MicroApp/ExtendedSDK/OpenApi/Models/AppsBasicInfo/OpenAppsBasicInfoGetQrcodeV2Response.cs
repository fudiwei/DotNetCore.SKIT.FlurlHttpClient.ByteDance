namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v2/basic_info/get_qr_code 接口的响应。</para>
    /// </summary>
    public class OpenAppsBasicInfoGetQrcodeV2Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置二维码链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qr_code_url")]
                [System.Text.Json.Serialization.JsonPropertyName("qr_code_url")]
                public string QrcodeUrl { get; set; } = default!;
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
