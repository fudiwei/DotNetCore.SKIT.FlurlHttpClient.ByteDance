namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/capacity/bind_doudian_account 接口的响应。</para>
    /// </summary>
    public class AppsCapacityBindDoudianAccountV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置抖店账号绑定状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doudian_account_status")]
                [System.Text.Json.Serialization.JsonPropertyName("doudian_account_status")]
                public int AccountStatus { get; set; }

                /// <summary>
                /// 获取或设置抖店开放平台注册地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doudian_register_url")]
                [System.Text.Json.Serialization.JsonPropertyName("doudian_register_url")]
                public string? RegisterUrl { get; set; }
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
