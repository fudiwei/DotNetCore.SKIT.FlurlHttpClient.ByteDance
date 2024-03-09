namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/icp_record/get_facial_recognition_url/ 接口的响应。</para>
    /// </summary>
    public class OpenAppsICPRecordGetFacialRecognitionUrlV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置人证核验 Token。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("facial_recognition_token")]
                [System.Text.Json.Serialization.JsonPropertyName("facial_recognition_token")]
                public string FacialRecognitionToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置人证核验链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("facial_recognition_url")]
                [System.Text.Json.Serialization.JsonPropertyName("facial_recognition_url")]
                public string FacialRecognitionUrl { get; set; } = default!;
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
