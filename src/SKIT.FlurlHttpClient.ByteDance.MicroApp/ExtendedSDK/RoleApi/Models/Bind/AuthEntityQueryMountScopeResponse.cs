namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_mountscope 接口的响应。</para>
    /// </summary>
    public class AuthEntityQueryMountScopeResponse : DouyinMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置已授权能力列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scope_list")]
        [System.Text.Json.Serialization.JsonPropertyName("scope_list")]
        public int[] MountScopeList { get; set; } = default!;

        /// <summary>
        /// 获取或设置绑定状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
