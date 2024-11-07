namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/auth/get_related_id/ 接口的响应。</para>
    /// </summary>
    public class AppsAuthGetRelatedIdV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置用户在相同主体下的唯一标志。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allied_id")]
                [System.Text.Json.Serialization.JsonPropertyName("allied_id")]
                public string AlliedId { get; set; } = default!;
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
