namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /platform/v1/webhook/reset_secret/ 接口的响应。</para>
    /// </summary>
    public class OpenPlatformWebhookResetSecretV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置 Webhook Secret。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("secret")]
                [System.Text.Json.Serialization.JsonPropertyName("secret")]
                public string Secret { get; set; } = default!;
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
