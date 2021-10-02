namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_iopTrade_Distribution 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/65/680 </para>
    /// </summary>
    public class IOPTradeDistributionEvent : TikTokShopEvent<IOPTradeDistributionEvent.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置厂商店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                public long SupplierShopId { get; set; }

                /// <summary>
                /// 获取或设置代打店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_id")]
                [System.Text.Json.Serialization.JsonPropertyName("user_id")]
                public long DistributeShopId { get; set; }

                /// <summary>
                /// 获取或设置代打订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("distr_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("distr_order_id")]
                public string DistributeOrderId { get; set; } = default!;
            }
        }
    }
}
