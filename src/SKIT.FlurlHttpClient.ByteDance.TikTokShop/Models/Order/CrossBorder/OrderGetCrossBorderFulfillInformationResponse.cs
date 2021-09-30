namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/getCrossBorderFulfillInfo 接口的响应。</para>
    /// </summary>
    public class OrderGetCrossBorderFulfillInformationResponse : TikTokShopResponse<OrderGetCrossBorderFulfillInformationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置店铺订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
                public string ShopOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置物流公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company")]
                [System.Text.Json.Serialization.JsonPropertyName("company")]
                public string CompanyName { get; set; } = default!;

                /// <summary>
                /// 获取或设置物流公司编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_code")]
                [System.Text.Json.Serialization.JsonPropertyName("company_code")]
                public string CompanyCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品单 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_order_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_order_ids")]
                public string[] SKUOrderIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_code")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                public string? LogisticsNumber { get; set; }

                /// <summary>
                /// 获取或设置电子面单链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("way_bill_url")]
                [System.Text.Json.Serialization.JsonPropertyName("way_bill_url")]
                public string? WaybillUrl { get; set; }

                /// <summary>
                /// 获取或设置大头笔。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mark")]
                [System.Text.Json.Serialization.JsonPropertyName("mark")]
                public string? Mark { get; set; }

                /// <summary>
                /// 获取或设置商品件数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_num")]
                [System.Text.Json.Serialization.JsonPropertyName("product_num")]
                public int ProductCount { get; set; }
            }
        }
    }
}
