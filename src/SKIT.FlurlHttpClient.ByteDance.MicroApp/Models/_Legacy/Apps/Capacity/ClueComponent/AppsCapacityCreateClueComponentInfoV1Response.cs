namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/create_clue_component_info 接口的响应。</para>
    /// </summary>
    public class AppsCapacityCreateClueComponentInfoV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置线索组件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("config_id")]
                [System.Text.Json.Serialization.JsonPropertyName("config_id")]
                public string ConfigId { get; set; } = default!;
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
