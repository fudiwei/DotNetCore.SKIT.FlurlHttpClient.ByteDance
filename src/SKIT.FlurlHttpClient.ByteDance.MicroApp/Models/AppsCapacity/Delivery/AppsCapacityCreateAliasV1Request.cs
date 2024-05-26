namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /aweme/apps/v1/alias/create_alias/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityCreateAliasV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序别名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alias_word")]
        [System.Text.Json.Serialization.JsonPropertyName("alias_word")]
        public string Alias { get; set; } = string.Empty;
    }
}
