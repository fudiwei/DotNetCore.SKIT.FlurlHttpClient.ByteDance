namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityQueryMerchantCodeStatusResponse : ByteDanceMicroAppAuthEntityResponse
    {

        /// <summary>
        /// SUCCESS/PROCESSING/FAILED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// 状态描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("status_desc")]
        public string StatusDesc { get; set; } = string.Empty;
    }
}
