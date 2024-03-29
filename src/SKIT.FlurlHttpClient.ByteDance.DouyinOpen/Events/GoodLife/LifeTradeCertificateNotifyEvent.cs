namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 life_trade_certificate_notify 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/order.query/trade.certificate.notify ]]>
    /// </para>
    /// </summary>
    public class LifeTradeCertificateNotifyEvent : DouyinOpenEvent<LifeTradeCertificateNotifyEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                public static class Types
                {
                    public class Certificate
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                        public string CertificateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商家 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string AccountId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("action")]
                [System.Text.Json.Serialization.JsonPropertyName("action")]
                public string Action { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_time")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate")]
                public Types.Certificate Certificate { get; set; } = default!;
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public override Types.Content EventContent { get; set; } = default!;
    }
}
