using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_product_deal_data 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-02 下线。")]
    public class AppsDataAnalysisQueryProductDealDataV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProductDealData
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                        public string ProductName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支付总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                        public long PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商品销售量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_product_cnt")]
                        public int PayProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置商品支付人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_user_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_user_cnt")]
                        public int PayUserCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置商品交易分析数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deal_data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("deal_data_list")]
                public Types.ProductDealData[] ProductDealDataList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
