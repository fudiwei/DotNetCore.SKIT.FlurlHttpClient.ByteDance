namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Events
{
    /// <summary>
    /// <para>表示 PRODUCT_STATUS_CHANGE 事件。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/650956aff1fd3102b90b6261 ]]>
    /// </para>
    /// </summary>
    public class ProductStatusChangeEvent : TikTokShopEvent<ProductStatusChangeEvent.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string ProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string ProductStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("suspended_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("suspended_reason")]
                public string? RejectReason { get; set; }

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
