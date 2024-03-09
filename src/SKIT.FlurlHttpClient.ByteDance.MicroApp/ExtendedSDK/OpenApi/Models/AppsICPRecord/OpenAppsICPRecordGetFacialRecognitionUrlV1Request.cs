namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/icp_record/get_facial_recognition_url/ 接口的请求。</para>
    /// </summary>
    public class OpenAppsICPRecordGetFacialRecognitionUrlV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置省份编码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProvinceCode { get; set; } = string.Empty;
    }
}
