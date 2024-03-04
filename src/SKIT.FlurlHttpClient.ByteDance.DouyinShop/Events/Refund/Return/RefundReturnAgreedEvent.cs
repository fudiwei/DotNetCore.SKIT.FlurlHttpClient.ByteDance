namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_refund_RefundAgreed 消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://op.jinritemai.com/docs/message-docs/31/116 ]]>
    /// </para>
    /// </summary>
    public class RefundReturnAgreedEvent : DouyinShopEvent<RefundReturnAgreedEvent.Types.Data>
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
                /// 获取或设置申请退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                public int RefundAmount { get; set; }

                /// <summary>
                /// 获取或设置申请退款运费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_post_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_post_amount")]
                public int RefundPostAmount { get; set; }

                /// <summary>
                /// 获取或设置申请退款的卡券的数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_voucher_num")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_voucher_num")]
                public int RefundVoucherCount { get; set; }

                /// <summary>
                /// 获取或设置售后原因编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason_code")]
                [System.Text.Json.Serialization.JsonPropertyName("reason_code")]
                public int ReasonCode { get; set; }

                /// <summary>
                /// 获取或设置同意退货申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agree_time")]
                [System.Text.Json.Serialization.JsonPropertyName("agree_time")]
                public long AgreeTimestamp { get; set; }
            }
        }
    }
}
