namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_ad_settlement_list 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryAdSettlementListV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Settlement
                    {
                        /// <summary>
                        /// 获取或设置结算单编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_serial")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_serial")]
                        public string SerialNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算单名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算周期（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_period")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_period")]
                        public string PeriodString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置发票税率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_rate")]
                        public double TaxRate { get; set; }

                        /// <summary>
                        /// 获取或设置结算金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_total_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_total_amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置结算状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结算单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_list")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_list")]
                public Types.Settlement[] SettlementList { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
