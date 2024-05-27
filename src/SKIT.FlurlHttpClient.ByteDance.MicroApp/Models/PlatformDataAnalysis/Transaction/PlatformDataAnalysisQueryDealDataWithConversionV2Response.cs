using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_deal_data_with_conversion/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryDealDataWithConversionV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class DealData
                    {
                        /// <summary>
                        /// 获取或设置小程序曝光次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MpShowPv")]
                        [System.Text.Json.Serialization.JsonPropertyName("MpShowPv")]
                        public int MicroAppShowPV { get; set; }

                        /// <summary>
                        /// 获取或设置小程序曝光人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MpShowUv")]
                        [System.Text.Json.Serialization.JsonPropertyName("MpShowUv")]
                        public int MicroAppShowUV { get; set; }

                        /// <summary>
                        /// 获取或设置进入小程序次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MpDrainagePv")]
                        [System.Text.Json.Serialization.JsonPropertyName("MpDrainagePv")]
                        public int MicroAppDrainagePV { get; set; }

                        /// <summary>
                        /// 获取或设置进入小程序人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MpDrainageUv")]
                        [System.Text.Json.Serialization.JsonPropertyName("MpDrainageUv")]
                        public int MicroAppDrainageUV { get; set; }

                        /// <summary>
                        /// 获取或设置创建订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CreateOrderCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("CreateOrderCount")]
                        public int CreateOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建订单人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CreateUserCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("CreateUserCount")]
                        public int CreateUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("PayOrderCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("PayOrderCount")]
                        public int PayOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("PayPeopleCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("PayPeopleCount")]
                        public int PayUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("RefundOrderCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("RefundOrderCount")]
                        public int RefundOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_order_amount")]
                        public long RefundOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("RefundPeopleCount")]
                        [System.Text.Json.Serialization.JsonPropertyName("RefundPeopleCount")]
                        public int RefundUserCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置流量转化数据信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Data")]
                [System.Text.Json.Serialization.JsonPropertyName("Data")]
                public Types.DealData DealData { get; set; } = default!;
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
