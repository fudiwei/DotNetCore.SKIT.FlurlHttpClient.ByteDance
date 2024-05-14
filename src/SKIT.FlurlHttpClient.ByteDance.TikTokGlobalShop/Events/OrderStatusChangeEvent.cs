namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Events
{
    /// <summary>
    /// <para>表示 ORDER_STATUS_CHANGE 事件。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650300b8a57708028b430b4a ]]>
    /// </para>
    /// </summary>
    public class OrderStatusChangeEvent : TikTokShopEvent<OrderStatusChangeEvent.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public string OrderStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置是否是延期订单。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_on_hold_order")]
                [System.Text.Json.Serialization.JsonPropertyName("is_on_hold_order")]
                public bool? IsOnHoldOrder { get; set; }
            }
        }
    }
}
