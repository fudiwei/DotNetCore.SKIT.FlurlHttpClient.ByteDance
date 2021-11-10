using System.Collections.Generic;

/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/ad/get 接口的请求。</para>
    /// </summary>
    public class AdvertisingGetRequest : OceanEngineRequest
    {
        public static class Types
        {
            public class Filter
            {
                /// <summary>
                /// 获取或设置广告计划 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ids")]
                [System.Text.Json.Serialization.JsonPropertyName("ids")]
                public IList<long>? AdvertisingIdList { get; set; }

                /// <summary>
                /// 获取或设置广告计划名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_name")]
                public string? AdvertisingName { get; set; }

                /// <summary>
                /// 获取或设置出价方式列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pricing_list")]
                [System.Text.Json.Serialization.JsonPropertyName("pricing_list")]
                public IList<string>? PricingTypeList { get; set; }

                /// <summary>
                /// 获取或设置广告计划状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string? Status { get; set; }

                /// <summary>
                /// 获取或设置广告组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("campaign_id")]
                [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                public long? CampaignId { get; set; }

                /// <summary>
                /// 获取或设置创建日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_create_time")]
                public string? CreateDateString { get; set; }

                /// <summary>
                /// 获取或设置修改日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_modify_time")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_modify_time")]
                public string? UpdateDateString { get; set; }
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
