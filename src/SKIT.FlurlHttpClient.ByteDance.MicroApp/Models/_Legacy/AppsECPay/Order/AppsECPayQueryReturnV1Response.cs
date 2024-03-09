namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/v1/query_return 接口的响应。</para>
    /// </summary>
    public class AppsECPayQueryReturnV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Return
            {
                /// <summary>
                /// 获取或设置小程序第三方平台应用 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thirdparty_id")]
                [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
                public string? ComponentAppId { get; set; }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户结算单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_settle_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_settle_no")]
                public string OutSettleNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置担保交易分帐单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_no")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_no")]
                public string SettleNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户回退单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_return_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_return_no")]
                public string OutReturnNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置平台回退单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_no")]
                [System.Text.Json.Serialization.JsonPropertyName("return_no")]
                public string ReturnNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置回退描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("return_desc")]
                public string ReturnDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置回退商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
                public string MerchantId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置回退金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("return_amount")]
                public int ReturnAmount { get; set; }

                /// <summary>
                /// 获取或设置回退状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_status")]
                [System.Text.Json.Serialization.JsonPropertyName("return_status")]
                public string ReturnStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置回退失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                public string? FailReason { get; set; }

                /// <summary>
                /// 获取或设置回退成功时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
                public long? FinishTimestamp { get; set; }

                /// <summary>
                /// 获取或设置自定义字段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cp_extra")]
                [System.Text.Json.Serialization.JsonPropertyName("cp_extra")]
                public string? Extra { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置分账回退信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_info")]
        [System.Text.Json.Serialization.JsonPropertyName("return_info")]
        public Types.Return Return { get; set; } = default!;
    }
}
