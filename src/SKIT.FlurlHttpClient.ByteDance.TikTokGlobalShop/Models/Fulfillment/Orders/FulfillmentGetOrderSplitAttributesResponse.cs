namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/{version}/orders/split_attributes 接口的响应。</para>
    /// </summary>
    public class FulfillmentGetOrderSplitAttributesResponse : TikTokShopResponse<FulfillmentGetOrderSplitAttributesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SplitAttribute
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否可分单。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_split")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_split")]
                        public bool CanSplit { get; set; }

                        /// <summary>
                        /// 获取或设置原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? Reason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置拆分属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("split_attributes")]
                [System.Text.Json.Serialization.JsonPropertyName("split_attributes")]
                public Types.SplitAttribute[] SplitAttributeList { get; set; } = default!;
            }
        }
    }
}
