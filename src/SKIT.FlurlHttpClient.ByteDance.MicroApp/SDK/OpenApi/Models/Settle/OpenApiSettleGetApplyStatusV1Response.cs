namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/settle/get_apply_status 接口的响应。</para>
    /// </summary>
    public class OpenApiSettleGetApplyStatusV1Response : ByteDanceMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置入驻状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_status")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_status")]
                public int ApplyStatus { get; set; }

                /// <summary>
                /// 获取或设置对公认证链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_url")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_url")]
                public string? VerifyUrl { get; set; }

                /// <summary>
                /// 获取或设置失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                public string? FailReason { get; set; }
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
