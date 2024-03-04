using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/adlib/ad/detail/ 接口的响应。</para>
    /// </summary>
    public class ResearchAdlibAdDetailResponse : TikTokV2Response<ResearchAdlibAdDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Advertisement
                    {
                        public static class Types
                        {
                            public class Video
                            {
                                /// <summary>
                                /// 获取或设置视频 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url")]
                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                public string Url { get; set; } = default!;
                            }

                            public class Reach
                            {
                                /// <summary>
                                /// 获取或设置 UV。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("unique_users_seen")]
                                [System.Text.Json.Serialization.JsonPropertyName("unique_users_seen")]
                                public string UniqueUsersSeen { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置各国家的 UV。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("unique_users_seen_by_country")]
                                [System.Text.Json.Serialization.JsonPropertyName("unique_users_seen_by_country")]
                                public IDictionary<string, string> UniqueUsersSeenByCountry { get; set; } = default!;
                            }

                            public class Rejection
                            {
                                /// <summary>
                                /// 获取或设置拒绝原因列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reasons")]
                                [System.Text.Json.Serialization.JsonPropertyName("reasons")]
                                public string[]? ReasonList { get; set; }

                                /// <summary>
                                /// 获取或设置受影响的国家代码列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("affected_countries")]
                                [System.Text.Json.Serialization.JsonPropertyName("affected_countries")]
                                public string[]? AffectedCountrieCodeList { get; set; }

                                /// <summary>
                                /// 获取或设置报告来源。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reporting_source")]
                                [System.Text.Json.Serialization.JsonPropertyName("reporting_source")]
                                public string? ReportingSource { get; set; }

                                /// <summary>
                                /// 获取或设置自动化审查通知。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("automated_notice")]
                                [System.Text.Json.Serialization.JsonPropertyName("automated_notice")]
                                public string? AutomatedNotice { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置广告 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long AdId { get; set; }

                        /// <summary>
                        /// 获取或设置首次曝光日期字符串（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_shown_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_shown_date")]
                        public string FirstShownDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置末次曝光日期字符串（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("last_shown_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("last_shown_date")]
                        public string LastShownDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("videos")]
                        [System.Text.Json.Serialization.JsonPropertyName("videos")]
                        public Types.Video[] VideoList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_urls")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_urls")]
                        public string[] ImageList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置触客信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reach")]
                        [System.Text.Json.Serialization.JsonPropertyName("reach")]
                        public Types.Reach Reach { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核拒绝信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rejection_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("rejection_info")]
                        public Types.Rejection? Rejection { get; set; }
                    }

                    public class Advertiser
                    {
                        public static class Types
                        {
                            public class TikTokAccount
                            {
                                /// <summary>
                                /// 获取或设置用户资料页 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("profile_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("profile_url")]
                                public string ProfileUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置用户头像 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("avatar_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
                                public string AvatarUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置粉丝数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("follower_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("follower_count")]
                                public long FollowerCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long BusinessId { get; set; }

                        /// <summary>
                        /// 获取或设置广告主名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_name")]
                        public string BusinessName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置国家代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("country_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("country_code")]
                        public string CountryCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置资金来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("paid_by")]
                        [System.Text.Json.Serialization.JsonPropertyName("paid_by")]
                        public string PaidBy { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 TikTok 账户信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tiktok_account")]
                        [System.Text.Json.Serialization.JsonPropertyName("tiktok_account")]
                        public Types.TikTokAccount TikTokAccount { get; set; } = default!;
                    }

                    public class AdGroup
                    {
                        public static class Types
                        {
                            public class Target
                            {
                                /// <summary>
                                /// 获取或设置目标用户数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("number_of_users_targeted")]
                                [System.Text.Json.Serialization.JsonPropertyName("number_of_users_targeted")]
                                public string UsersTargeted { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置目标国家代码列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("country")]
                                [System.Text.Json.Serialization.JsonPropertyName("country")]
                                public string[] CountryCodeList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置目标年龄分布字典。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("age")]
                                [System.Text.Json.Serialization.JsonPropertyName("age")]
                                public IDictionary<string, bool> AgeMap { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置目标性别分布字典。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gender")]
                                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                                public IDictionary<string, bool> GenderMap { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置受众目标。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("audience_targeting")]
                                [System.Text.Json.Serialization.JsonPropertyName("audience_targeting")]
                                public string? AudienceTargeting { get; set; }

                                /// <summary>
                                /// 获取或设置视频交互类别。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("video_interactions")]
                                [System.Text.Json.Serialization.JsonPropertyName("video_interactions")]
                                public string? VideoInteractions { get; set; }

                                /// <summary>
                                /// 获取或设置创建者交互类别。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("creator_interactions")]
                                [System.Text.Json.Serialization.JsonPropertyName("creator_interactions")]
                                public string? CreatorInteractions { get; set; }

                                /// <summary>
                                /// 获取或设置兴趣类别。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("interest")]
                                [System.Text.Json.Serialization.JsonPropertyName("interest")]
                                public string? Interest { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置投放目标信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("targeting_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("targeting_info")]
                        public Types.Target Target { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置广告信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad")]
                [System.Text.Json.Serialization.JsonPropertyName("ad")]
                public Types.Advertisement Advertisement { get; set; } = default!;

                /// <summary>
                /// 获取或设置广告主信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("advertiser")]
                [System.Text.Json.Serialization.JsonPropertyName("advertiser")]
                public Types.Advertiser Advertiser { get; set; } = default!;

                /// <summary>
                /// 获取或设置广告组信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_group")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_group")]
                public Types.AdGroup AdGroup { get; set; } = default!;
            }
        }
    }
}
