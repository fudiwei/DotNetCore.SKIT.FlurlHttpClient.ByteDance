using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_aweme_permission_list 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-01 下线。")]
    public class AppsCapacityQueryAwemePermissionListV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Capacity
                    {
                        public static class Types
                        {
                            public class Permission
                            {
                                public static class Types
                                {
                                    public class Scope
                                    {
                                        /// <summary>
                                        /// 获取或设置作用域 Key。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("scope")]
                                        [System.Text.Json.Serialization.JsonPropertyName("scope")]
                                        public string ScopeKey { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置权限 Key。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("permission_key")]
                                [System.Text.Json.Serialization.JsonPropertyName("permission_key")]
                                public string PermissionKey { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置权限名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("permission_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("permission_name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置权限描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("permission_desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("permission_desc")]
                                public string Description { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置是否可以申请。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("can_apply")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("can_apply")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                public bool CanApply { get; set; }

                                /// <summary>
                                /// 获取或设置状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置申请拒绝原因列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_reason_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_reason_list")]
                                public string[]? RejectReasonList { get; set; }

                                /// <summary>
                                /// 获取或设置作用域列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scope_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("scope_list")]
                                public Types.Scope[] ScopeList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置权限类别。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("permission_category")]
                        [System.Text.Json.Serialization.JsonPropertyName("permission_category")]
                        public string PermissionCategory { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置权限列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("permission_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("permission_list")]
                        public Types.Permission[] PermissionList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置抖音开放能力列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Capacity[] CapacityList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
