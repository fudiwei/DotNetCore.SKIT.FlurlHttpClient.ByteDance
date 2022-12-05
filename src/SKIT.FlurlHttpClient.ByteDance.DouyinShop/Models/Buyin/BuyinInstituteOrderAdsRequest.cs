using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/instituteOrderAds 接口的请求。</para>
    /// </summary>
    public class BuyinInstituteOrderAdsRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置商品名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ids")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("order_ids")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
        public IList<string>? OrderIdList { get; set; }

        /// <summary>
        /// 获取或设置支付时间范围开始。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartPayTime { get; set; }

        /// <summary>
        /// 获取或设置支付时间范围结束。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndPayTime { get; set; }

        /// <summary>
        /// 获取或设置机构 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pid")]
        [System.Text.Json.Serialization.JsonPropertyName("pid")]
        public string? InstitutionId { get; set; }

        /// <summary>
        /// 获取或设置分销类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distribution_type")]
        [System.Text.Json.Serialization.JsonPropertyName("distribution_type")]
        public string? DistributionType { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置翻页索引。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string PageCursor { get; set; } = "0";

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? PageSize { get; set; }
    }
}
