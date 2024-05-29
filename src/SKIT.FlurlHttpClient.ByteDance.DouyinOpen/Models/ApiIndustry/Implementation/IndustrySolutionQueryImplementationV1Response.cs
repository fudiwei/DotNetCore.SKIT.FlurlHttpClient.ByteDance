namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/industry/v1/solution/query_impl 接口的响应。</para>
    /// </summary>
    public class IndustrySolutionQueryImplementationV1Response : DouyinOpenResponse
    {
        public static class Types
        {
            public class IndustryImplementation
            {
                public static class Types
                {
                    public class AbilityImplementation
                    {
                        /// <summary>
                        /// 获取或设置行业编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("industry_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
                        public string? IndustryCode { get; set; }

                        /// <summary>
                        /// 获取或设置开放能力 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ability_identity")]
                        [System.Text.Json.Serialization.JsonPropertyName("ability_identity")]
                        public string AbilityId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置实现名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string ImplementationName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置测试地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("test_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("test_url")]
                        public string? TestUrl { get; set; }

                        /// <summary>
                        /// 获取或设置生产地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("prod_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("prod_url")]
                        public string? ProductionUrl { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置解决方案 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("solution_id")]
                [System.Text.Json.Serialization.JsonPropertyName("solution_id")]
                public string SolutionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置扩展点能力实现列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extension_ability_impl_list")]
                [System.Text.Json.Serialization.JsonPropertyName("extension_ability_impl_list")]
                public Types.AbilityImplementation[]? ExtensionAbilityImplementationList { get; set; }
                
                /// <summary>
                /// 获取或设置消息配置实现列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message_ability_impl_list")]
                [System.Text.Json.Serialization.JsonPropertyName("message_ability_impl_list")]
                public Types.AbilityImplementation[]? MessageAbilityImplementationList { get; set; }
            }

            public class AppConfigItem
            {
                /// <summary>
                /// 获取或设置键。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity")]
                [System.Text.Json.Serialization.JsonPropertyName("identity")]
                public string Key { get; set; } = default!;

                /// <summary>
                /// 获取或设置值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置各行业实现列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("solution_eff_ability_impl_list")]
        [System.Text.Json.Serialization.JsonPropertyName("solution_eff_ability_impl_list")]
        public Types.IndustryImplementation[] IndustryImplementationList { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序配置项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_config_item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("app_config_item_list")]
        public Types.AppConfigItem[] AppConfigItemList { get; set; } = default!;
    }
}
