namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/game/wallet/get_balance 接口的响应。</para>
    /// </summary>
    public class AppsGameWalletGetBalanceResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// 获取或设置游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance")]
        [System.Text.Json.Serialization.JsonPropertyName("balance")]
        public int Balance { get; set; }

        /// <summary>
        /// 获取或设置赠送游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gen_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("gen_balance")]
        public int GenBalance { get; set; }

        /// <summary>
        /// 获取或设置累计充值游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("save_amt")]
        [System.Text.Json.Serialization.JsonPropertyName("save_amt")]
        public int SaveAmount { get; set; }

        /// <summary>
        /// 获取或设置历史总游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("save_sum")]
        [System.Text.Json.Serialization.JsonPropertyName("save_sum")]
        public int SaveSum { get; set; }

        /// <summary>
        /// 获取或设置历史总消费游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cost_sum")]
        [System.Text.Json.Serialization.JsonPropertyName("cost_sum")]
        public int CostSum { get; set; }

        /// <summary>
        /// 获取或设置历史累计收到游戏币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_sum")]
        [System.Text.Json.Serialization.JsonPropertyName("present_sum")]
        public int PresentSum { get; set; }
    }
}
