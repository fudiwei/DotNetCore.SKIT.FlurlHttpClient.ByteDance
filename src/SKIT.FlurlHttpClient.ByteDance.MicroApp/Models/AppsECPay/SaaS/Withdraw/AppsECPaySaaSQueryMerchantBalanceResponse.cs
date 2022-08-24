namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/query_merchant_balance 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSQueryMerchantBalanceResponse : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Account
            {
                /// <summary>
                /// 获取或设置在途余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("online_balance")]
                [System.Text.Json.Serialization.JsonPropertyName("online_balance")]
                public int OnlineBalance { get; set; }

                /// <summary>
                /// 获取或设置可提现余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("withdrawable_balacne")]
                [System.Text.Json.Serialization.JsonPropertyName("withdrawable_balacne")]
                public int WithdrawableBalance { get; set; }

                /// <summary>
                /// 获取或设置冻结准备金余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freeze_balance")]
                [System.Text.Json.Serialization.JsonPropertyName("freeze_balance")]
                public int FreezeBalance { get; set; }
            }

            public class Settlement
            {
                /// <summary>
                /// 获取或设置结算类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_type")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_type")]
                public int SettleType { get; set; }

                /// <summary>
                /// 获取或设置支付宝账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_account")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_account")]
                public string SettleAccount { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行卡号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bankcard_no")]
                [System.Text.Json.Serialization.JsonPropertyName("bankcard_no")]
                public string BankCardNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string BankName { get; set; } = default!;
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
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置余额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_info")]
        [System.Text.Json.Serialization.JsonPropertyName("account_info")]
        public Types.Account Account { get; set; } = default!;

        /// <summary>
        /// 获取或设置结算信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_info")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_info")]
        public Types.Settlement Settlement { get; set; } = default!;
    }
}
