namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/capacity/query_doudian_app 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryDoudianAppV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置应用绑定状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_status")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
                public int BindStatus { get; set; }

                /// <summary>
                /// 获取或设置抖店应用 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doudian_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("doudian_appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置抖店应用名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doudian_app_name")]
                [System.Text.Json.Serialization.JsonPropertyName("doudian_app_name")]
                public string? AppName { get; set; }
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
