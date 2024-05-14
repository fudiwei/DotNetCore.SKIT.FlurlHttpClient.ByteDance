namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Events
{
    /// <summary>
    /// <para>表示 CANCELLATION_STATUS_CHANGE 事件。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/65030150746462028285f657 ]]>
    /// </para>
    /// </summary>
    public class CancellationStatusChangeEvent : TikTokShopEvent<CancellationStatusChangeEvent.Types.Data>
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
                /// 获取或设置取消 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cancel_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string CancelId { get; set; } = default!;

                /// <summary>
                /// 获取或设置取消发起人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancellations_role")]
                [System.Text.Json.Serialization.JsonPropertyName("cancellations_role")]
                public string CancelRole { get; set; } = default!;

                /// <summary>
                /// 获取或设置取消状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel_status")]
                [System.Text.Json.Serialization.JsonPropertyName("cancel_status")]
                public string CancelStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }
    }
}
