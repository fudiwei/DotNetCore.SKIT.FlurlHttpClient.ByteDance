namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/privacy_setting/query/ 接口的响应。</para>
    /// </summary>
    public class AppsPrivacySettingQueryV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置是否已配置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_configure")]
                [System.Text.Json.Serialization.JsonPropertyName("is_configure")]
                public bool IsConfigured { get; set; }
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
