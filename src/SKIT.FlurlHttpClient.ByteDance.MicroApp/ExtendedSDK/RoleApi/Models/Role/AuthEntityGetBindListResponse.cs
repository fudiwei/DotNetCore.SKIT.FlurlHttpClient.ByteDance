namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /get_bind_list 接口的响应。</para>
    /// </summary>
    public class AuthEntityGetBindListResponse : DouyinMicroAppRoleApiResponse
    {
        public static class Types
        {
            public class BindInfo
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户实体 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_entity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_entity_id")]
                public string MerchantEnityId { get; set; } = default!;

                /// <summary>
                /// 获取或设置行业编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_code")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
                public int IndustryCode { get; set; }

                /// <summary>
                /// 获取或设置行业角色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_role")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
                public int IndustryRole { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置绑定角色列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_info_list")]
        public Types.BindInfo[] BindInfoList { get; set; } = default!;
    }
}
