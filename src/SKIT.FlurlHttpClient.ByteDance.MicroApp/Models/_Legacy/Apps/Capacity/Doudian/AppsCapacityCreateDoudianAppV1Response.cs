namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/capacity/create_doudian_app 接口的响应。</para>
    /// </summary>
    public class AppsCapacityCreateDoudianAppV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置抖店应用 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doudian_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("doudian_appid")]
                public string AppId { get; set; } = default!;
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
