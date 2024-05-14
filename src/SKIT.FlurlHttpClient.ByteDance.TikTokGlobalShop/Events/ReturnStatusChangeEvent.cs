namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Events
{
    /// <summary>
    /// <para>表示 RETURN_STATUS_CHANGE 事件。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/65030162bb2a4d028d50cc51 ]]>
    /// </para>
    /// </summary>
    public class ReturnStatusChangeEvent : TikTokShopEvent<ReturnStatusChangeEvent.Types.Data>
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
                /// 获取或设置退货 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_id")]
                [System.Text.Json.Serialization.JsonPropertyName("return_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string ReturnId { get; set; } = default!;

                /// <summary>
                /// 获取或设置退货发起人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_role")]
                [System.Text.Json.Serialization.JsonPropertyName("return_role")]
                public string ReturnRole { get; set; } = default!;

                /// <summary>
                /// 获取或设置退货类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_type")]
                [System.Text.Json.Serialization.JsonPropertyName("return_type")]
                public string ReturnType { get; set; } = default!;

                /// <summary>
                /// 获取或设置退货状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_status")]
                [System.Text.Json.Serialization.JsonPropertyName("return_status")]
                public string ReturnStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

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
