namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/group/setting/disable/ 接口的请求。</para>
    /// </summary>
    public class IMGroupSettingDisableRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置管理配置类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_setting_type")]
        [System.Text.Json.Serialization.JsonPropertyName("group_setting_type")]
        public int SettingType { get; set; }
    }
}
