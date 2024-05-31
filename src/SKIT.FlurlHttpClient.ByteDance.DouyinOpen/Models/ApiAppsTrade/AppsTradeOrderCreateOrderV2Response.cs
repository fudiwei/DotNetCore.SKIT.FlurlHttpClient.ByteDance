namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/order/create_order 接口的响应。</para>
    /// </summary>
    public class AppsTradeOrderCreateOrderV2Response : DouyinOpenResponse<AppsTradeOrderCreateOrderV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class ItemOrderInfo
                    {
                        public static class Types
                        {
                            public class ItemOrder
                            {
                                /// <summary>
                                /// 获取或设置商品单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                                public string ItemOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                public int Price { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                        public string GoodsId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品单号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_id_list")]
                        public string[] ItemOrderIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_detail")]
                        public Types.ItemOrder[] ItemOrderList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置开发者订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
                public string OutOrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置调起收银台的支付订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
                public string PayOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置调起收银台的 Token。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_order_token")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_order_token")]
                public string PayOrderToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品单信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_order_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("item_order_info_list")]
                public Types.ItemOrderInfo[] ItemOrderInfoList { get; set; } = default!;
            }
        }
    }
}
