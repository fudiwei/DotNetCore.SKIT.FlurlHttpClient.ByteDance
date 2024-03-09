namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/icp_record/query_facial_recognition_status/ 接口的响应。</para>
    /// </summary>
    public class OpenAppsICPRecordQueryFacialRecognitionStatusV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置人证核验状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("facial_recognition_status")]
                [System.Text.Json.Serialization.JsonPropertyName("facial_recognition_status")]
                public int FacialRecognitionStatus { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
