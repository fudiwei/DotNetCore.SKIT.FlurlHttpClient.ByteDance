namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/roleGet 接口的响应。</para>
    /// </summary>
    public class IOPRoleGetResponse : DouyinShopResponse<IOPRoleGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置身份类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("role_type")]
                [System.Text.Json.Serialization.JsonPropertyName("role_type")]
                public int RoleType { get; set; }
            }
        }
    }
}
