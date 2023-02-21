namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/partner/order/get 接口的响应。</para>
    /// </summary>
    public class GoodLifePartnerOrderGetV1Response : DouyinOpenResponse<GoodLifePartnerOrderGetV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class ProductItem
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_status")]
                        public int ProductStatus { get; set; }

                        /// <summary>
                        /// 获取或设置商品售价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_price")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ActualPrice { get; set; }

                        /// <summary>
                        /// 获取或设置商品分佣比例（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_ratio")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CommissionRatio { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_id")]
                [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                public string AccountId { get; set; } = default!;

                /// <summary>
                /// 获取或设置合作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cooperation_content")]
                [System.Text.Json.Serialization.JsonPropertyName("cooperation_content")]
                public int CooperationContentType { get; set; }

                /// <summary>
                /// 获取或设置合作开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置合作结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置收费类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("charge_type")]
                [System.Text.Json.Serialization.JsonPropertyName("charge_type")]
                public int ChargeType { get; set; }

                /// <summary>
                /// 获取或设置分佣比例（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_ratio")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? CommissionRatio { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_name")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                public string MerchantName { get; set; } = default!;

                /// <summary>
                /// 获取或设置服务名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string ProductName { get; set; } = default!;

                /// <summary>
                /// 获取或设置下单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置商品佣金配置列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_items")]
                [System.Text.Json.Serialization.JsonPropertyName("product_items")]
                public Types.ProductItem[]? ProductItemList { get; set; }
            }
        }
    }
}
