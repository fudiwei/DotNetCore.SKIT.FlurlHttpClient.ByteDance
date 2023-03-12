namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/activity/items/remove 接口的响应。</para>
    /// </summary>
    public class PromotionActivityItemsRemoveResponse : TikTokShopResponse<PromotionActivityItemsRemoveResponse.Types.Data>
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
                public string PromotionId { get; set; } = default!;

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
            }
        }
    }
}
