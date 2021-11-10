using System.Collections.Generic;

/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/creative/get 接口的请求。</para>
    /// </summary>
    public class CreativeGetRequest : OceanEngineRequest
    {
        public static class Types
        {
            public class Filter
            {
                /// <summary>
                /// 获取或设置创意 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creative_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("creative_ids")]
                public IList<long>? CreativeIdList { get; set; }

                /// <summary>
                /// 获取或设置广告组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("campaign_id")]
                [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                public long? CampaignId { get; set; }

                /// <summary>
                /// 获取或设置广告计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                public long? AdvertisingId { get; set; }

                /// <summary>
                /// 获取或设置创意标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creative_title")]
                [System.Text.Json.Serialization.JsonPropertyName("creative_title")]
                public string? CreativeTitle { get; set; }

                /// <summary>
                /// 获取或设置推广目的。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("landing_type")]
                [System.Text.Json.Serialization.JsonPropertyName("landing_type")]
                public string? LandingType { get; set; }

                /// <summary>
                /// 获取或设置出价方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pricing")]
                [System.Text.Json.Serialization.JsonPropertyName("pricing")]
                public string? PricingType { get; set; }

                /// <summary>
                /// 获取或设置创意状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string? Status { get; set; }

                /// <summary>
                /// 获取或设置创意素材类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("image_mode")]
                public string? ImageMode { get; set; }

                /// <summary>
                /// 获取或设置创建日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creative_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("creative_create_time")]
                public string? CreateDateString { get; set; }

                /// <summary>
                /// 获取或设置更新日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creative_modify_time")]
                [System.Text.Json.Serialization.JsonPropertyName("creative_modify_time")]
                public string? CreateUpdateString { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置过滤条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filtering")]
        [System.Text.Json.Serialization.JsonPropertyName("filtering")]
        public Types.Filter? Filter { get; set; }

        /// <summary>
        /// 获取或设置查询字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fields")]
        [System.Text.Json.Serialization.JsonPropertyName("fields")]
        public IList<string>? FieldList { get; set; }

        /// <summary>
        /// 获取或设置分页页码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }
    }
}
