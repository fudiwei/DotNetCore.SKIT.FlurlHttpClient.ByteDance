namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/advertiser/avatar/get 接口的响应。</para>
    /// </summary>
    public class AdvertiserAvatarGetResponse : OceanEngineResponse<AdvertiserAvatarGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Avatar
                    {
                        /// <summary>
                        /// 获取或设置当前头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("web_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("web_uri")]
                        public string? AvatarWebUrl { get; set; }

                        /// <summary>
                        /// 获取或设置审核中头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_web_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_web_uri")]
                        public string? AuditingAvatarWebUrl { get; set; }

                        /// <summary>
                        /// 获取或设置宽度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int? AuditingAvatarWidth { get; set; }

                        /// <summary>
                        /// 获取或设置高度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int? AuditingAvatarHeight { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置广告主 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("advertiser_id")]
                [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                public long AdvertiserId { get; set; }

                /// <summary>
                /// 获取或设置头像审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar_status")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar_status")]
                public int AvatarStatus { get; set; }

                /// <summary>
                /// 获取或设置头像审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar_reason")]
                public string? AvatarRejectReason { get; set; }

                /// <summary>
                /// 获取或设置品牌审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_status")]
                [System.Text.Json.Serialization.JsonPropertyName("source_status")]
                public int SourceStatus { get; set; }

                /// <summary>
                /// 获取或设置品牌信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_info")]
                [System.Text.Json.Serialization.JsonPropertyName("source_info")]
                public string? SourceInfo { get; set; }

                /// <summary>
                /// 获取或设置品牌审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("source_reason")]
                public string? SouceRejectReason { get; set; }

                /// <summary>
                /// 获取或设置头像信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar_info")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar_info")]
                public Types.Avatar? Avatar { get; set; }
            }
        }
    }
}
