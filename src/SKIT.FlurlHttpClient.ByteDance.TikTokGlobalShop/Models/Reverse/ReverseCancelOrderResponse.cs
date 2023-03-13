namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /reverse/order/cancel 接口的响应。</para>
    /// </summary>
    public class ReverseCancelOrderResponse : TikTokShopResponse<ReverseCancelOrderResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置撤回订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reverse_main_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("reverse_main_order_id")]
                public string? ReverseOrderId { get; set; }
            }
        }
    }
}
