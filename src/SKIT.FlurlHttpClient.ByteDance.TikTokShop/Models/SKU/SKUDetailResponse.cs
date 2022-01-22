using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /sku/detail 接口的响应。</para>
    /// </summary>
    public class SKUDetailResponse : TikTokShopResponse<SKUDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : SKUListResponse.Types.SKU
            {
                public static class Types
                {
                    public class CustomsReport
                    {
                        /// <summary>
                        /// 获取或设置海关代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hs_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("hs_code")]
                        public string HSCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置法定第一计量数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_measure_qty")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_measure_qty")]
                        public int FirstMeasureQuantity { get; set; }

                        /// <summary>
                        /// 获取或设置法定第二计量数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_measure_qty")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_measure_qty")]
                        public int SecondMeasureQuantity { get; set; }

                        /// <summary>
                        /// 获取或设置法定第一计量单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_measure_unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_measure_unit")]
                        public string FirstMeasureUnit { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置法定第二计量单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_measure_unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_measure_unit")]
                        public string SecondMeasureUnit { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置售卖单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                        public string Unit { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("report_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("report_name")]
                        public string ReportName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品牌。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("report_brand_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("report_brand_name")]
                        public string ReportBrandName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用途。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("usage")]
                        [System.Text.Json.Serialization.JsonPropertyName("usage")]
                        public string Usage { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置规格型号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("g_model")]
                        [System.Text.Json.Serialization.JsonPropertyName("g_model")]
                        public string Model { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置条形码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bar_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("bar_code")]
                        public string BarCode { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置海关申报要素列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customs_report_info")]
                [System.Text.Json.Serialization.JsonPropertyName("customs_report_info")]
                public Types.CustomsReport[]? CustomsReportList { get; set; }

                /// <summary>
                /// 获取或设置区域仓中的发货时效或库存字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ship_rule_map")]
                [System.Text.Json.Serialization.JsonPropertyName("ship_rule_map")]
                public IDictionary<string, int>? ShipRuleMap { get; set; }
            }
        }
    }
}
