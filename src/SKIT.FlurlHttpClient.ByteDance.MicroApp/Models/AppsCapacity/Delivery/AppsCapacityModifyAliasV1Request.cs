namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/modify_alias/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityModifyAliasV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置修改前小程序别名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("before_alias")]
        [System.Text.Json.Serialization.JsonPropertyName("before_alias")]
        public string OldAlias { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置修改后小程序别名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_alias")]
        [System.Text.Json.Serialization.JsonPropertyName("after_alias")]
        public string NewAlias { get; set; } = string.Empty;
    }
}
