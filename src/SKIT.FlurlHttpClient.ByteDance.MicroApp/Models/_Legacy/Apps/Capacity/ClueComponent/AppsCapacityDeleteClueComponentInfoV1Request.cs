namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /apps/v1/capacity/delete_clue_component_info 接口的请求。</para>
    /// </summary>
    public class AppsCapacityDeleteClueComponentInfoV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置线索组件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config_id")]
        [System.Text.Json.Serialization.JsonPropertyName("config_id")]
        public string ConfigId { get; set; } = string.Empty;
    }
}
