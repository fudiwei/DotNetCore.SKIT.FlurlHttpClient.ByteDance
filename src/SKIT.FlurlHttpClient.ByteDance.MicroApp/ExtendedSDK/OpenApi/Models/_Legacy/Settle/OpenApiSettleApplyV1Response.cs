namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/settle/apply 接口的响应。</para>
    /// </summary>
    public class OpenApiSettleApplyV1Response : OpenApiLegacyResponseBase
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置申请请求 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_id")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
                public string ApplyId { get; set; } = default!;
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
