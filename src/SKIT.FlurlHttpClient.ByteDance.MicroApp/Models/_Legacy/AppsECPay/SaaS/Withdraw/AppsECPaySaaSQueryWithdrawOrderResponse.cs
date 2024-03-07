namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/query_withdraw_order 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSQueryWithdrawOrderResponse : DouyinMicroAppResponse
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
        /// 获取或设置提现状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置提现状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("status_msg")]
        public string StatusMessage { get; set; } = default!;
    }
}
