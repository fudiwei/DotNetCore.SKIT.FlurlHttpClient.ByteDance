namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/orderDetail 接口的响应。</para>
    /// </summary>
    public class OrderDetailResponse : DouyinShopResponse<OrderDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ShopOrder : OrderSearchListResponse.Types.Data.Types.ShopOrder
                    {
                    }
                }

                /// <summary>
                /// 获取或设置订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_order_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_order_detail")]
                public Types.ShopOrder ShopOrder { get; set; } = default!;
            }
        }
    }
}
