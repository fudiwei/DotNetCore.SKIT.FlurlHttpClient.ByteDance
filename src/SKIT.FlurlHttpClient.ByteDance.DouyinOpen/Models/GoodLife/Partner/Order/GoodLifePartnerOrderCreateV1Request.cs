namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/partner/order/create 接口的请求。</para>
    /// </summary>
    public class GoodLifePartnerOrderCreateV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置合作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cooperation_content")]
        [System.Text.Json.Serialization.JsonPropertyName("cooperation_content")]
        public int CooperationContentType { get; set; }

        /// <summary>
        /// 获取或设置合作开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置合作结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置收费类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("charge_type")]
        [System.Text.Json.Serialization.JsonPropertyName("charge_type")]
        public int ChargeType { get; set; }

        /// <summary>
        /// 获取或设置分佣比例（单位：万分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commission_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("commission_ratio")]
        public int? CommissionRatio { get; set; }
    }
}
