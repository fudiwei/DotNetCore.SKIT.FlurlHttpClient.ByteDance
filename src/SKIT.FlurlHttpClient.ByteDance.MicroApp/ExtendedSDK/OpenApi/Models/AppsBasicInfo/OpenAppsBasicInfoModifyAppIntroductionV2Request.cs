namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v2/basic_info/modify_app_intro 接口的请求。</para>
    /// </summary>
    public class OpenAppsBasicInfoModifyAppIntroductionV2Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置准备修改的小程序简介。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_intro")]
        [System.Text.Json.Serialization.JsonPropertyName("new_intro")]
        public string NewIntroduction { get; set; } = string.Empty;
    }
}
