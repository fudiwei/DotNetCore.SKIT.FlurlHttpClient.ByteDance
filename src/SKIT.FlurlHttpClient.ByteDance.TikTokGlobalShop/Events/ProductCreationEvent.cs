namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Events
{
    /// <summary>
    /// <para>表示 PRODUCT_CREATION 事件。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.tiktokshop.com/docv2/page/663c98b566828e02e4515580 ]]>
    /// </para>
    /// </summary>
    public class ProductCreationEvent : TikTokShopEvent<ProductCreationEvent.Types.Data>
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
                /// 获取或设置商品类型列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                public string[] ProductTypeList { get; set; } = default!;

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
