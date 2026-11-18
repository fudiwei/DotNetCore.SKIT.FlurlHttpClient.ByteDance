namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    public abstract class AppsTaskBoxResponseBase : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public int Error { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public override string? ErrorMessage { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Error == 0;
        }
    }
}
