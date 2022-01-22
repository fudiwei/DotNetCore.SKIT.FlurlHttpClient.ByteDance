namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/agent/advertiser/update 接口的请求。</para>
    /// </summary>
    public class AgentAdvertiserUpdateRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置账户名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置联系人。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contacter")]
        [System.Text.Json.Serialization.JsonPropertyName("contacter")]
        public string? Contact { get; set; }

        /// <summary>
        /// 获取或设置手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phonenumber")]
        [System.Text.Json.Serialization.JsonPropertyName("phonenumber")]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// 获取或设置固话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("telephone")]
        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
        public string? TeleNumber { get; set; }
    }
}
