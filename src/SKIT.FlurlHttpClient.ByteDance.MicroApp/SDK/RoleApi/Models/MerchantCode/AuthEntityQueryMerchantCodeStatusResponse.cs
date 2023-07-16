namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_merchantcode_status 接口的响应。</para>
    /// </summary>
    public class AuthEntityQueryMerchantCodeStatusResponse : ByteDanceMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置激活状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("status_desc")]
        public string StatusDescription { get; set; } = default!;
    }
}
