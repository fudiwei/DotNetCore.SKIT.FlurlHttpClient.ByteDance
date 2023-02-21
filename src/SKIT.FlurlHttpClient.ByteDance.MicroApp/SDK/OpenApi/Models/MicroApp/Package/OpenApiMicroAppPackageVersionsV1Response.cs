using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/package/versions 接口的响应。</para>
    /// </summary>
    public class OpenApiMicroAppPackageVersionsV1Response : ByteDanceMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class VersionInfo
                    {
                        /// <summary>
                        /// 获取或设置服务类目列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categories")]
                        [System.Text.Json.Serialization.JsonPropertyName("categories")]
                        public string[] CategoryList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序拥有者的头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("developer_avatar")]
                        [System.Text.Json.Serialization.JsonPropertyName("developer_avatar")]
                        public string DeveloperAvatarUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序拥有者的账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("developer_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("developer_id")]
                        public string DeveloperId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序拥有者的昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("developer_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("developer_name")]
                        public string DeveloperName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置版本号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("version")]
                        [System.Text.Json.Serialization.JsonPropertyName("version")]
                        public string Version { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置更新信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("summary")]
                        [System.Text.Json.Serialization.JsonPropertyName("summary")]
                        public string Summary { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ctime")]
                        [System.Text.Json.Serialization.JsonPropertyName("ctime")]
                        public long CreateTimestamp { get; set; }
                    }

                    public class LatestVersionInfo : VersionInfo
                    {
                        /// <summary>
                        /// 获取或设置是否已提审。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("has_audit")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("has_audit")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool HasAudited { get; set; }

                        /// <summary>
                        /// 获取或设置截图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("screenshot")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("screenshot")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                        public string[]? ScreenshotUrlList { get; set; }
                    }

                    public class AuditVersionInfo : VersionInfo
                    {
                        /// <summary>
                        /// 获取或设置通过审核的宿主端列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("approvedApps")]
                        [System.Text.Json.Serialization.JsonPropertyName("approvedApps")]
                        public string[]? ApprovedApps { get; set; }

                        /// <summary>
                        /// 获取或设置是否已发布。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("has_publish")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("has_publish")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool HasPublished { get; set; }

                        /// <summary>
                        /// 获取或设置是否是被下架的版本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_illegal_version")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_illegal_version")]
                        public bool IsIllegalVersion { get; set; }

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置审核不通过原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置审核不通过原因字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reasonDetail")]
                        [System.Text.Json.Serialization.JsonPropertyName("reasonDetail")]
                        public IDictionary<string, string[]>? RejectReasonDetailMap { get; set; }

                        /// <summary>
                        /// 获取或设置附件字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attachInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("attachInfo")]
                        public IDictionary<string, string>? AttachmentMap { get; set; }
                    }

                    public class CurrentVersionInfo : VersionInfo
                    {
                        public static class Types
                        {
                            public class Rollback
                            {
                                /// <summary>
                                /// 获取或设置是否可以回退。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("can_rollback")]
                                [System.Text.Json.Serialization.JsonPropertyName("can_rollback")]
                                public bool CanRollback { get; set; }

                                /// <summary>
                                /// 获取或设置可以回退到的上一版本号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("last_version")]
                                [System.Text.Json.Serialization.JsonPropertyName("last_version")]
                                public string? LastVersion { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置通过审核的宿主端列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("approvedApps")]
                        [System.Text.Json.Serialization.JsonPropertyName("approvedApps")]
                        public string[]? ApprovedApps { get; set; }

                        /// <summary>
                        /// 获取或设置没有通过审核的宿主端列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("notApprovedApps")]
                        [System.Text.Json.Serialization.JsonPropertyName("notApprovedApps")]
                        public string[]? NotApprovedApps { get; set; }

                        /// <summary>
                        /// 获取或设置是否已下架。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("has_down")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("has_down")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool HasDowned { get; set; }

                        /// <summary>
                        /// 获取或设置开发者平台账号 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("uid")]
                        [System.Text.Json.Serialization.JsonPropertyName("uid")]
                        public long? UID { get; set; }

                        /// <summary>
                        /// 获取或设置审核不通过原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置审核不通过原因字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reasonDetail")]
                        [System.Text.Json.Serialization.JsonPropertyName("reasonDetail")]
                        public IDictionary<string, string[]>? RejectReasonDetailMap { get; set; }

                        /// <summary>
                        /// 获取或设置附件字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attachInfo")]
                        [System.Text.Json.Serialization.JsonPropertyName("attachInfo")]
                        public IDictionary<string, string>? AttachmentMap { get; set; }

                        /// <summary>
                        /// 获取或设置回退信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rollback")]
                        [System.Text.Json.Serialization.JsonPropertyName("rollback")]
                        public Types.Rollback? Rollback { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置测试版本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("latest")]
                [System.Text.Json.Serialization.JsonPropertyName("latest")]
                public Types.LatestVersionInfo? LatestVersionInfo { get; set; }

                /// <summary>
                /// 获取或设置审核版本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit")]
                [System.Text.Json.Serialization.JsonPropertyName("audit")]
                public Types.AuditVersionInfo? AuditVersionInfo { get; set; }

                /// <summary>
                /// 获取或设置线上版本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("current")]
                [System.Text.Json.Serialization.JsonPropertyName("current")]
                public Types.CurrentVersionInfo? CurrentVersionInfo { get; set; }
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
