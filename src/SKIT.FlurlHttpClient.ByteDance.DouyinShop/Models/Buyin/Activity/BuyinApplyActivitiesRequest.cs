using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/applyActivities 接口的请求。</para>
    /// </summary>
    public class BuyinApplyActivitiesRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Product
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置活动价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_price")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_price")]
                public int ActivityPrice { get; set; }

                /// <summary>
                /// 获取或设置活动佣金比例（范围：1～50）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_activity_ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("product_activity_ratio")]
                public double? ActivityRatio { get; set; }

                /// <summary>
                /// 获取或设置参与活动库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_stock")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_stock")]
                public int? PromotionStock { get; set; }

                /// <summary>
                /// 获取或设置赠品详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gift_info")]
                [System.Text.Json.Serialization.JsonPropertyName("gift_info")]
                public string? GiftInformation { get; set; }

                /// <summary>
                /// 获取或设置活动价实现方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_step")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_step")]
                public string? PromotionStep { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 获取或设置招商服务费率（范围：0～40）。与字段 <see cref="ServiceRatio"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_rate")]
        [System.Text.Json.Serialization.JsonPropertyName("service_rate")]
        public int? ServiceRate { get; set; }

        /// <summary>
        /// 获取或设置招商服务费率（范围：0～40）。与字段 <see cref="ServiceRate"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("service_ratio")]
        public double? ServiceRatio { get; set; }

        /// <summary>
        /// 获取或设置店铺联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("products")]
        [System.Text.Json.Serialization.JsonPropertyName("products")]
        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
    }
}
