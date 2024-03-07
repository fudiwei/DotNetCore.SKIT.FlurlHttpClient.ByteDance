namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_bind_toc_list 接口的响应。</para>
    /// </summary>
    public class AuthEntityQueryBindToCListResponse : DouyinMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置抖音号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_id_list")]
        public string[] AwemeIdList { get; set; } = default!;
    }
}
