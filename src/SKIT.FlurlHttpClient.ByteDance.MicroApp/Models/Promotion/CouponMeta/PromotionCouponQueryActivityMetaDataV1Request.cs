namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/query_activity_meta_data/ 接口的请求。</para>
    /// </summary>
    public class PromotionCouponQueryActivityMetaDataV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置活动状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int ActivityStatus { get; set; }

        /// <summary>
        /// 获取或设置发放场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("send_scene")]
        public int SendScene { get; set; }

        /// <summary>
        /// 获取或设置券模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
        public string? CouponMetaId { get; set; }

        /// <summary>
        /// 获取或设置券名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_name")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_name")]
        public string? CouponName { get; set; }

        /// <summary>
        /// 获取或设置优惠类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount_type")]
        [System.Text.Json.Serialization.JsonPropertyName("discount_type")]
        public int? DiscountType { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        [System.Text.Json.Serialization.JsonPropertyName("page_num")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;
    }
}
