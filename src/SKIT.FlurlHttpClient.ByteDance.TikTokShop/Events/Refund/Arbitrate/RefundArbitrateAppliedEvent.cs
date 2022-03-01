namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_refund_ArbitrateApplied 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/31/256 </para>
    /// </summary>
    public class RefundArbitrateAppliedEvent : TikTokShopEvent<RefundArbitrateAppliedEvent.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置商铺订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("p_id")]
                [System.Text.Json.Serialization.JsonPropertyName("p_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string ShopOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("s_id")]
                [System.Text.Json.Serialization.JsonPropertyName("s_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string SKUOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                public int ShopId { get; set; }

                /// <summary>
                /// 获取或设置售后单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_id")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string AftersaleId { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_status")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_status")]
                public int AftersaleStatus { get; set; }

                /// <summary>
                /// 获取或设置售后单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_type")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_type")]
                public int AftersaleType { get; set; }

                /// <summary>
                /// 获取或设置仲裁单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("arbitrate_id")]
                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_id")]
                public string ArbitrateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置仲裁状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("arbitrate_status")]
                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_status")]
                public int ArbitrateStatus { get; set; }
            }
        }
    }
}
