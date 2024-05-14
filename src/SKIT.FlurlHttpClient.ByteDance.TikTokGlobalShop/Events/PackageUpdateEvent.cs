namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Events
{
    /// <summary>
    /// <para>表示 PACKAGE_UPDATE 事件。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650955cabace3e02b73cc886 ]]>
    /// </para>
    /// </summary>
    public class PackageUpdateEvent : TikTokShopEvent<PackageUpdateEvent.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Package
                    {
                        /// <summary>
                        /// 获取或设置包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string? PackageId { get; set; }

                        /// <summary>
                        /// 获取或设置订单 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
                        public string[]? OrderIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置事件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sc_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sc_type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置角色类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("role_type")]
                [System.Text.Json.Serialization.JsonPropertyName("role_type")]
                public string RoleType { get; set; } = default!;

                /// <summary>
                /// 获取或设置包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_list")]
                [System.Text.Json.Serialization.JsonPropertyName("package_list")]
                public Types.Package[] PackageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }
    }
}
