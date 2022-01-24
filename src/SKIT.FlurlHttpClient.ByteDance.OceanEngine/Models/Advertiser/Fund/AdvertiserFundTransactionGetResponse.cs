using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/advertiser/fund/transaction/get 接口的响应。</para>
    /// </summary>
    public class AdvertiserFundTransactionGetResponse : OceanEngineResponse<AdvertiserFundTransactionGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Transaction
                    {
                        /// <summary>
                        /// 获取或设置广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                        public long AdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置流水类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_type")]
                        public string TransactionType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置交易总金额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public double Amount { get; set; }

                        /// <summary>
                        /// 获取或设置现金总金额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cash")]
                        [System.Text.Json.Serialization.JsonPropertyName("cash")]
                        public double TotalCash { get; set; }

                        /// <summary>
                        /// 获取或设置赠款总金额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("grant")]
                        [System.Text.Json.Serialization.JsonPropertyName("grant")]
                        public double TotalGrant { get; set; }

                        /// <summary>
                        /// 获取或设置返货总金额（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_goods")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_goods")]
                        public double TotalReturnGoods { get; set; }

                        /// <summary>
                        /// 获取或设置交易流水号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_seq")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_seq")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                        public string TransactionSequenceNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置付款方广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remitter")]
                        [System.Text.Json.Serialization.JsonPropertyName("remitter")]
                        public long RemitterAdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置收款方广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payee")]
                        [System.Text.Json.Serialization.JsonPropertyName("payee")]
                        public long PayeeAdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置返点（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dealbase")]
                        [System.Text.Json.Serialization.JsonPropertyName("dealbase")]
                        public double Dealbase { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置流水列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Transaction[] TransactionList { get; set; } = default!;
            }
        }
    }
}
