namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /seller/{version}/permissions 接口的响应。</para>
    /// </summary>
    public class SellerGetPermissionsResponse : TikTokShopResponse<SellerGetPermissionsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置权限列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("permissions")]
                [System.Text.Json.Serialization.JsonPropertyName("permissions")]
                public string[] PermissionList { get; set; } = default!;
            }
        }
    }
}
