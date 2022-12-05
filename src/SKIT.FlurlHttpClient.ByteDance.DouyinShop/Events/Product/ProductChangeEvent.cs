namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_product_change 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/60/686 </para>
    /// </summary>
    public class ProductChangeEvent : DouyinShopEvent<ProductChangeEvent.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置商品变更事件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("event")]
                [System.Text.Json.Serialization.JsonPropertyName("event")]
                public int Event { get; set; }

                /// <summary>
                /// 获取或设置店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                public int ShopId { get; set; }

                /// <summary>
                /// 获取或设置外部商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                public long OutProductId { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置包含触审字段以及驳回原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("check_reject_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("check_reject_reason")]
                public string? RejectReason { get; set; }

                /// <summary>
                /// 获取或设置事件时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }
    }
}
