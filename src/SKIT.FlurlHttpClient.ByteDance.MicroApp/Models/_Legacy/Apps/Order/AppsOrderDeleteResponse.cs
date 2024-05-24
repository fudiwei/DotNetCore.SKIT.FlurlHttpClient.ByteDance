namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/order/delete 接口的响应。</para>
    /// </summary>
    public class AppsOrderDeleteResponse : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_code")]
        [System.Text.Json.Serialization.JsonPropertyName("err_code")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取或设置 JSON 格式的生活服务关联业务推送结果与业务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body")]
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? DataJson { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ErrorCode == 0;
        }
    }
}
