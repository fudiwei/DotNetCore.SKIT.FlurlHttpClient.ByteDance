using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/{version}/coupons/search 接口的请求。</para>
    /// </summary>
    public class PromotionSearchCouponsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202406</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202406;

        /// <summary>
        /// 获取或设置关键字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("title_keyword")]
        public string? Keyword { get; set; }

        /// <summary>
        /// 获取或设置优惠券状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public IList<string>? CouponStatusList { get; set; }

        /// <summary>
        /// 获取或设置展示方式列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_type")]
        [System.Text.Json.Serialization.JsonPropertyName("display_type")]
        public IList<string>? DisplayTypeList { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置分页令牌。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PageToken { get; set; }
    }
}
