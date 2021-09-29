namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /btas/getInspectionOrder 接口的响应。</para>
    /// </summary>
    public class BTASGetInspectionOrderResponse : TikTokShopResponse<BTASGetInspectionOrderResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProductOrder
                    {
                        /// <summary>
                        /// 获取或设置商品单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_order_id")]
                        public string ProductOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单码列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_code")]
                        public string[] OrderCodeList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_orders")]
                [System.Text.Json.Serialization.JsonPropertyName("product_orders")]
                public Types.ProductOrder[] ProductOrderList { get; set; } = default!;
            }
        }
    }
}
