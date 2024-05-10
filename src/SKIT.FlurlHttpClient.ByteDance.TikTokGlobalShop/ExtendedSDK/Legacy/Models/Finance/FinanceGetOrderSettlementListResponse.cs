namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /finance/order/settlements 接口的响应。</para>
    /// </summary>
    public class FinanceGetOrderSettlementListResponse : TikTokShopLegacyResponse<FinanceGetOrderSettlementListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Settlement
                    {
                        public static class Types
                        {
                            public class SettlementInfo : FinanceSearchSettlementsResponse.Types.Data.Types.Settlement.Types.SettlementInfo
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置结算 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unique_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("unique_key")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long SettlementId { get; set; }

                        /// <summary>
                        /// 获取或设置结算状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sett_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("sett_status")]
                        public int SettlementStatus { get; set; }

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                        public string? ProductName { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string? SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                        public string? SKUName { get; set; }

                        /// <summary>
                        /// 获取或设置结算信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_info")]
                        public Types.SettlementInfo SettlementInfo { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置结算列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_list")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_list")]
                public Types.Settlement[] SettlementList { get; set; } = default!;
            }
        }
    }
}
