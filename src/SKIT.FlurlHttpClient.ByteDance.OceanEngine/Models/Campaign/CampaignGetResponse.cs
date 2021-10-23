using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/campaign/get 接口的响应。</para>
    /// </summary>
    public class CampaignGetResponse : OceanEngineResponse<CampaignGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Campaign
                    {
                        /// <summary>
                        /// 获取或设置广告组 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public long? CampaignId { get; set; }

                        /// <summary>
                        /// 获取或设置广告组名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置广告组预算（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("budget")]
                        [System.Text.Json.Serialization.JsonPropertyName("budget")]
                        public double? Budget { get; set; }

                        /// <summary>
                        /// 获取或设置广告组预算类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("budget_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("budget_mode")]
                        public string? BudgetMode { get; set; }

                        /// <summary>
                        /// 获取或设置广告组推广目的。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("landing_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("landing_type")]
                        public string? LandingType { get; set; }

                        /// <summary>
                        /// 获取或设置广告组营销目的。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("marketing_purpose")]
                        [System.Text.Json.Serialization.JsonPropertyName("marketing_purpose")]
                        public string? MarketingPurpose { get; set; }

                        /// <summary>
                        /// 获取或设置广告组状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string? Status { get; set; }

                        /// <summary>
                        /// 获取或设置修改时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("modify_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
                        public long? ModifyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置修改时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_modify_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_modify_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? UpdateTime { get; set; }

                        /// <summary>
                        /// 获取或设置商品类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_related_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_related_num")]
                        public string? DeliveryRelatedType { get; set; }

                        /// <summary>
                        /// 获取或设置投放类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_mode")]
                        public string? DeliveryMode { get; set; }
                    }

                    public class Pagination : AgentAdvertiserSelectResponse.Types.Data.Types.Pagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置广告组列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Campaign[] CampaignList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Types.Pagination Pagination { get; set; } = default!;
            }
        }
    }
}
