using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/insurance 接口的响应。</para>
    /// </summary>
    public class OrderInsuranceResponse : DouyinShopResponse<OrderInsuranceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Policy
                    {
                        public static class Types
                        {
                            public class Goods
                            {
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分类 ID 字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("category_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                                public string CategoryIdString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品详情页 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("show_page_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("show_page_url")]
                                public string? PageUrl { get; set; }

                                /// <summary>
                                /// 获取或设置商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                public int Count { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置保单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ins_policy_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("ins_policy_no")]
                        public string InsurancePolicyNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置预计退保费用（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("approximate_return_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("approximate_return_fee")]
                        public int ApproximateReturnFee { get; set; }

                        /// <summary>
                        /// 获取或设置总保费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_premium")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_premium")]
                        public int TotalPremium { get; set; }

                        /// <summary>
                        /// 获取或设置用户支付的保费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_premium")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_premium")]
                        public int UserPremium { get; set; }

                        /// <summary>
                        /// 获取或设置商家支付的保费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_premium")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_premium")]
                        public int MerchantPremium { get; set; }

                        /// <summary>
                        /// 获取或设置平台承担的保费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_premium")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_premium")]
                        public int PlatformPremium { get; set; }

                        /// <summary>
                        /// 获取或设置保单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置保费状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("premium_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("premium_status")]
                        public int PremiumStatus { get; set; }

                        /// <summary>
                        /// 获取或设置申述状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appeal_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("appeal_status")]
                        public int AppealStatus { get; set; }

                        /// <summary>
                        /// 获取或设置理赔状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("claim_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("claim_status")]
                        public int ClaimStatus { get; set; }

                        /// <summary>
                        /// 获取或设置保险公司名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                        public string CompanyName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置保险客服电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("insurance_hotline")]
                        [System.Text.Json.Serialization.JsonPropertyName("insurance_hotline")]
                        public string? CompanyHotline { get; set; }

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_info_list")]
                        public Types.Goods[] GoodsList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否允许申诉。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_allow_appeal")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_allow_appeal")]
                        public bool IsAllowAppeal { get; set; }

                        /// <summary>
                        /// 获取或设置理赔或申述失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                        public string? FailReason { get; set; }

                        /// <summary>
                        /// 获取或设置出保时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ins_ensured_time_begin")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("ins_ensured_time_begin")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset InsuranceEnsuredBeginTime { get; set; }

                        /// <summary>
                        /// 获取或设置过期时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ins_ensured_time_end")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("ins_ensured_time_end")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset InsuranceEnsuredEndTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置保单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("policy_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("policy_info_list")]
                public Types.Policy[] PolicyList { get; set; } = default!;
            }
        }
    }
}
