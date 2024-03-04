using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/advertiser/qualification/select_v2 接口的响应。</para>
    /// </summary>
    public class AdvertiserQualificationSelectV2Response : OceanEngineResponse<AdvertiserQualificationSelectV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Qualification
                    {
                        public static class Types
                        {
                            public class Image
                            {
                                /// <summary>
                                /// 获取或设置附件 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("attachment_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("attachment_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
                                public string AttachmentId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置附件图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                                public string ImageUrl { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置资质 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_id")]
                        public int QualificationId { get; set; }

                        /// <summary>
                        /// 获取或设置资质类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
                        public int QualificationType { get; set; }

                        /// <summary>
                        /// 获取或设置资质预览 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("picture_preview_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("picture_preview_url")]
                        public string? PreviewUrl { get; set; }

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置审核时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                        public DateTimeOffset? AuditTime { get; set; }

                        /// <summary>
                        /// 获取或设置资质图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_list")]
                        public Types.Image[] ImageList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置资质列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Qualification[] QualificationList { get; set; } = default!;
            }
        }
    }
}
