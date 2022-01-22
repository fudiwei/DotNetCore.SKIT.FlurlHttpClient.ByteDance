namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /btas/getOrderInspectionResult 接口的响应。</para>
    /// </summary>
    public class BTASGetOrderInspectionResultResponse : TikTokShopResponse<BTASGetOrderInspectionResultResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_order_id")]
                public string ProductOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_code")]
                [System.Text.Json.Serialization.JsonPropertyName("order_code")]
                public string OrderCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置证书编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certification_code")]
                [System.Text.Json.Serialization.JsonPropertyName("certification_code")]
                public string? CertificationCode { get; set; }

                /// <summary>
                /// 获取或设置鉴定单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspection_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("inspection_order_id")]
                public string InspectionOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置鉴定结果类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspection_result")]
                [System.Text.Json.Serialization.JsonPropertyName("inspection_result")]
                public int InspectionResult { get; set; }

                /// <summary>
                /// 获取或设置鉴定明细。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public string InspectionDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置鉴定备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspection_comment")]
                [System.Text.Json.Serialization.JsonPropertyName("inspection_comment")]
                public string InspectionComment { get; set; } = default!;

                /// <summary>
                /// 获取或设置鉴定费用（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspection_cost")]
                [System.Text.Json.Serialization.JsonPropertyName("inspection_cost")]
                public int InspectionCost { get; set; }

                /// <summary>
                /// 获取或设置物流费用（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_cost")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_cost")]
                public int LogisticsCost { get; set; }

                /// <summary>
                /// 获取或设置鉴定结果时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inspection_time")]
                [System.Text.Json.Serialization.JsonPropertyName("inspection_time")]
                public long InspectionTimestamp { get; set; }
            }
        }
    }
}
