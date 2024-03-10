namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/auth/get_openid_by_b/ 接口的请求。</para>
    /// </summary>
    public class DouyinAuthGetOpenIdByBV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置 B 端应用 ClientKey。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("b_client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("b_client_key")]
        public string BClientKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户在 B 端下的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string BOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 C 端应用 ClientKey。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("c_client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("c_client_key")]
        public string CClientKey { get; set; } = string.Empty;
    }
}
