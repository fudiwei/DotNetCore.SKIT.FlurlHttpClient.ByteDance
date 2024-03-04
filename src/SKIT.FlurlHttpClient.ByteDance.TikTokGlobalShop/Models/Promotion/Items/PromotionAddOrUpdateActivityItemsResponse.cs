namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/activity/items/addorupdate 接口的响应。</para>
    /// </summary>
    public class PromotionAddOrUpdateActivityItemsResponse : TikTokShopResponse<PromotionAddOrUpdateActivityItemsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置请求序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_serial_no")]
                [System.Text.Json.Serialization.JsonPropertyName("request_serial_no")]
                public string RequestSerialNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置促销 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_id")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string PromotionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_count")]
                [System.Text.Json.Serialization.JsonPropertyName("item_count")]
                public int ProductCount { get; set; }
            }
        }
    }
}
