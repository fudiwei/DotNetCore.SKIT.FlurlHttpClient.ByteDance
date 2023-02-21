namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/partner/product_commission/save 接口的响应。</para>
    /// </summary>
    public class GoodLifePartnerProductCommissionSaveV1Response : DouyinOpenResponse<GoodLifePartnerProductCommissionSaveV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class InvalidProductItem
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public string ProductId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品分佣比例（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_ratio")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CommissionRatio { get; set; }

                        /// <summary>
                        /// 获取或设置达人分佣比例（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("alliance_commission_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("alliance_commission_ratio")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int AllianceCommissionRatio { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置记录 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("record_id")]
                [System.Text.Json.Serialization.JsonPropertyName("record_id")]
                public string RecordId { get; set; } = default!;

                /// <summary>
                /// 获取或设置无效的商品佣金配置列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invalid_commission_product_list")]
                [System.Text.Json.Serialization.JsonPropertyName("invalid_commission_product_list")]
                public Types.InvalidProductItem[]? InvalidProductItemList { get; set; }
            }
        }
    }
}
