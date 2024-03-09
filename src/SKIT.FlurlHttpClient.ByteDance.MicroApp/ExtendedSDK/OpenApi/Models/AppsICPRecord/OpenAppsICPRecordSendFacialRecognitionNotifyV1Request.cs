namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/icp_record/send_facial_recognition_notify/ 接口的请求。</para>
    /// </summary>
    public class OpenAppsICPRecordSendFacialRecognitionNotifyV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置省份编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_code")]
        [System.Text.Json.Serialization.JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序负责人手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_incharge_people_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("app_incharge_people_phone")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
