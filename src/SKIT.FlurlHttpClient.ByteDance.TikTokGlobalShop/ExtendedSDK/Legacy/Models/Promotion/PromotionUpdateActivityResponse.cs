namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/activity/update 接口的响应。</para>
    /// </summary>
    public class PromotionUpdateActivityResponse : TikTokShopLegacyResponse<PromotionUpdateActivityResponse.Types.Data>
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
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }
    }
}
