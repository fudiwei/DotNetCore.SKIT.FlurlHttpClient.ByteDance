using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/industry/v1/solution/set_impl 接口的请求。</para>
    /// </summary>
    public class IndustrySolutionSetImplementationV1Request : DouyinOpenRequest
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
                        /// 获取或设置开放能力 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ability_identity")]
                        [System.Text.Json.Serialization.JsonPropertyName("ability_identity")]
                        public string AbilityId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置开放能力类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ability_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("ability_type")]
                        public int AbilityType { get; set; }

                        /// <summary>
                        /// 获取或设置是否删除当前生效的实现地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_delete")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_delete")]
                        public bool IsDelete { get; set; }

                        /// <summary>
                        /// 获取或设置实现名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("impl_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("impl_name")]
                        public string ImplementationName { get; set; } = string.Empty;

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
                public string SolutionId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开放能力实现列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_ability_impl_list")]
                [System.Text.Json.Serialization.JsonPropertyName("open_ability_impl_list")]
                public IList<Types.AbilityImplementation> OpenAbilityImplementationList { get; set; } = new List<Types.AbilityImplementation>();
            }

            public class AppConfigItem
            {
                /// <summary>
                /// 获取或设置键。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity")]
                [System.Text.Json.Serialization.JsonPropertyName("identity")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置操作人。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operator")]
        [System.Text.Json.Serialization.JsonPropertyName("operator")]
        public string Operator { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发布原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("release_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("release_reason")]
        public string ReleaseReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置各行业实现列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_impl_list")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_impl_list")]
        public IList<Types.IndustryImplementation> IndustryImplementationList { get; set; } = new List<Types.IndustryImplementation>();

        /// <summary>
        /// 获取或设置小程序配置项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_config_item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("app_config_item_list")]
        public IList<Types.AppConfigItem> AppConfigItemList { get; set; } = new List<Types.AppConfigItem>();
    }
}
