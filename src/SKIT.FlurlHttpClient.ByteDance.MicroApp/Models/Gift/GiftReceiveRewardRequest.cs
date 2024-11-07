namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/gift/receive_reward 接口的请求。</para>
    /// </summary>
    public class GiftReceiveRewardRequest : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置礼包码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gift_code")]
        [System.Text.Json.Serialization.JsonPropertyName("gift_code")]
        public string GiftCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置兑奖用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置兑奖通用唯一 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uuid")]
        [System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string RequestUUID { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_type")]
        [System.Text.Json.Serialization.JsonPropertyName("env_type")]
        public string? EnvironmentType { get; set; }
    }
}
