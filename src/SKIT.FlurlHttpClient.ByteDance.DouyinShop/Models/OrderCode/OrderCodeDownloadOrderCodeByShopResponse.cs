namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /orderCode/downloadOrderCodeByShop 接口的响应。</para>
    /// </summary>
    public class OrderCodeDownloadOrderCodeByShopResponse : DouyinShopResponse<OrderCodeDownloadOrderCodeByShopResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_success")]
                [System.Text.Json.Serialization.JsonPropertyName("is_success")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("error_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("error_desc")]
                public string? ErrorDescription { get; set; }

                /// <summary>
                /// 获取或设置送检方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_type")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                public int DeliveryType { get; set; }

                /// <summary>
                /// 获取或设置出仓方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ship_type")]
                [System.Text.Json.Serialization.JsonPropertyName("ship_type")]
                public int ShipType { get; set; }

                /// <summary>
                /// 获取或设置订单码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_code")]
                [System.Text.Json.Serialization.JsonPropertyName("order_code")]
                public string? OrderCode { get; set; }
            }
        }
    }
}
