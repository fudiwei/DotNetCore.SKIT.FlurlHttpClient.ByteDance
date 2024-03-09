namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/icp_record/query_facial_recognition_status/ 接口的请求。</para>
    /// </summary>
    public class OpenAppsICPRecordQueryFacialRecognitionStatusV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置人证核验 Token。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FacialRecognitionToken { get; set; } = string.Empty;
    }
}
