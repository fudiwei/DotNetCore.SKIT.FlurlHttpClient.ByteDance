namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/v1/query_platform_order 接口的响应。</para>
    /// </summary>
    public class AppsECPayQueryPlatformOrderV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class PlatformOrder
            {
                public static class Types
                {
                    public class SettleInfo
                    {
                        public static class Types
                        {
                            public class SettleParameter
                            {
                                /// <summary>
                                /// 获取或设置分账金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                public int Amount { get; set; }

                                /// <summary>
                                /// 获取或设置分账方商户号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_uid")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
                                public string MerchantUid { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置自动结算单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_settle_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_settle_no")]
                        public string OutSettleNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序分账单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_no")]
                        public string SettleNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分账参数列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_param_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_param_list")]
                        public Types.SettleParameter[]? SettleParameterList { get; set; }

                        /// <summary>
                        /// 获取或设置结算渠道。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_way")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_way")]
                        public string SettleWay { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分账状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_status")]
                        public string SettleStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 CPS 佣金（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cps")]
                        [System.Text.Json.Serialization.JsonPropertyName("cps")]
                        public int CPS { get; set; }

                        /// <summary>
                        /// 获取或设置技术服务费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_charge")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_charge")]
                        public int ServiceCharge { get; set; }

                        /// <summary>
                        /// 获取或设置结算创建时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("created_at")]
                        [System.Text.Json.Serialization.JsonPropertyName("created_at")]
                        public string CreateTimeString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算完成时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settled_at")]
                        [System.Text.Json.Serialization.JsonPropertyName("settled_at")]
                        public string? SettleTimeString { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
                public string? OutOrderNumber { get; set; }

                /// <summary>
                /// 获取或设置对应的查询类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query_type")]
                [System.Text.Json.Serialization.JsonPropertyName("query_type")]
                public string QueryType { get; set; } = default!;

                /// <summary>
                /// 获取或设置自动结算明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_info_list")]
                public Types.SettleInfo[]? SettleInfoList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("platform_order")]
        [System.Text.Json.Serialization.JsonPropertyName("platform_order")]
        public Types.PlatformOrder PlatformOrder { get; set; } = default!;
    }
}
