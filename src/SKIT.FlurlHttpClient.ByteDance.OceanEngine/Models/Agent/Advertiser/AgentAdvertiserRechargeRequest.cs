namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/agent/advertiser/recharge 接口的请求。</para>
    /// </summary>
    public class AgentAdvertiserRechargeRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置代理商 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public long AgentId { get; set; }

        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置转账类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_type")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_type")]
        public string TransferType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置转账金额（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public decimal Amount { get; set; }
    }
}
