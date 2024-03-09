namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/icp_record/query_service_content_type_list/ 接口的响应。</para>
    /// </summary>
    public class OpenAppsICPRecordQueryServiceContentTypeListV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ServiceContentTypeInfo
                    {
                        /// <summary>
                        /// 获取或设置服务内容类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_content_type_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_content_type_id")]
                        public int ServiceContentTypeId { get; set; }

                        /// <summary>
                        /// 获取或设置服务内容类型名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_content_type_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_content_type_name")]
                        public string ServiceContentTypeName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置子服务内容类型列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_service_content_type_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_service_content_type_list")]
                        public ServiceContentTypeInfo[]? SubServiceContentTypeList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置服务内容类型列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_content_type_list")]
                [System.Text.Json.Serialization.JsonPropertyName("service_content_type_list")]
                public Types.ServiceContentTypeInfo[] ServiceContentTypeList { get; set; } = default!;
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
