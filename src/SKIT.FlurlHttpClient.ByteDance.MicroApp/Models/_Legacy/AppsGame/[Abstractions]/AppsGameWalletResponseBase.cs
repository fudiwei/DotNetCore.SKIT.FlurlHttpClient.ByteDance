namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    public abstract class AppsGameWalletResponseBase : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errcode")]
        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
        public int ErrorCode { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
        public override string? ErrorMessage { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ErrorCode == 0;
        }
    }
}
