using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/package_version/versions/ 接口的响应。</para>
    /// </summary>
    public class OpenAppsPackageVersionGetVersionsV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public abstract class VersionInfoBase
                    {
                        /// <summary>
                        /// 获取或设置服务类目列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categories")]
                        [System.Text.Json.Serialization.JsonPropertyName("categories")]
                        public string[] CategoryList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序管理员的头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("developer_avatar")]
                        [System.Text.Json.Serialization.JsonPropertyName("developer_avatar")]
                        public string DeveloperAvatarUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序管理员的账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("developer_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("developer_id")]
                        public string DeveloperId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序管理员的昵称。
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
                        /// 获取或设置版本通道。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("version_tag")]
                        [System.Text.Json.Serialization.JsonPropertyName("version_tag")]
                        public string VersionTag { get; set; } = default!;

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

                        /// <summary>
                        /// 获取或设置各宿主端附件字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attach_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("attach_info")]
                        public IDictionary<string, string>? AttachmentMap { get; set; }
                    }

                    public class LatestVersionInfo : VersionInfoBase
                    {
                        /// <summary>
                        /// 获取或设置是否已提审。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("has_audit")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("has_audit")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool HasAudited { get; set; }

                        /// <summary>
                        /// 获取或设置截图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("screenshot")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringArrayWithCommaSplitConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("screenshot")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringArrayWithCommaSplitConverter))]
                        public string[]? ScreenshotUrlList { get; set; }
                    }

                    public class AuditVersionInfo : VersionInfoBase
                    {
                        /// <summary>
                        /// 获取或设置通过审核的宿主端列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("approved_apps")]
                        [System.Text.Json.Serialization.JsonPropertyName("approved_apps")]
                        public string[]? ApprovedApps { get; set; }

                        /// <summary>
                        /// 获取或设置是否已发布。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("has_publish")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("has_publish")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
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
                        /// 获取或设置各宿主端审核不通过原因字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason_detail")]
                        public IDictionary<string, string[]>? RejectReasonDetailMap { get; set; }
                    }

                    public class GrayVersionInfo : VersionInfoBase
                    {
                        /// <summary>
                        /// 获取或设置各宿主端灰度比例字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("host_gray_scale")]
                        [System.Text.Json.Serialization.JsonPropertyName("host_gray_scale")]
                        public IDictionary<string, string>? HostGrayScaleMap { get; set; }
                    }

                    public class CurrentVersionInfo : VersionInfoBase
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
                        [Newtonsoft.Json.JsonProperty("approved_apps")]
                        [System.Text.Json.Serialization.JsonPropertyName("approved_apps")]
                        public string[]? ApprovedApps { get; set; }

                        /// <summary>
                        /// 获取或设置没有通过审核的宿主端列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("not_approved_apps")]
                        [System.Text.Json.Serialization.JsonPropertyName("not_approved_apps")]
                        public string[]? NotApprovedApps { get; set; }

                        /// <summary>
                        /// 获取或设置是否已下架。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("has_down")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("has_down")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool HasDowned { get; set; }

                        /// <summary>
                        /// 获取或设置开发者平台账号 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("uid")]
                        [System.Text.Json.Serialization.JsonPropertyName("uid")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long? UserUID { get; set; }

                        /// <summary>
                        /// 获取或设置审核不通过原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置各宿主端审核不通过原因字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason_detail")]
                        public IDictionary<string, string[]>? RejectReasonDetailMap { get; set; }

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
                /// 获取或设置灰度版本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gray")]
                [System.Text.Json.Serialization.JsonPropertyName("gray")]
                public Types.GrayVersionInfo? GrayVersionInfo { get; set; }

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
