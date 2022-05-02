namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/set_user_storage 接口的响应。</para>
    /// </summary>
    public class AppsSetUserStorageResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// 获取或设置错误代号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public int ErrorNumber { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ErrorNumber == 0;
        }
    }
}
