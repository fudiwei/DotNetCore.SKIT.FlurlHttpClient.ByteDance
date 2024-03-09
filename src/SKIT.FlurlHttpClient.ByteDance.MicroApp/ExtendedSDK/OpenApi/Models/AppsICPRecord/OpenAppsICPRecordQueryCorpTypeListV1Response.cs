namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/icp_record/query_corp_type_list/ 接口的响应。</para>
    /// </summary>
    public class OpenAppsICPRecordQueryCorpTypeListV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CorpTypeInfo
                    {
                        public static class Types
                        {
                            public class CredentialsTypeInfo
                            {
                                /// <summary>
                                /// 获取或设置证件类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("credentials_type_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("credentials_type_id")]
                                public int CredentialsTypeInfoId { get; set; }

                                /// <summary>
                                /// 获取或设置证件类型名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("credentials_type_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("credentials_type_name")]
                                public string CredentialsTypeInfoName { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置主体类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("corp_type_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("corp_type_id")]
                        public int CorpTypeId { get; set; }

                        /// <summary>
                        /// 获取或设置主体类型名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("corp_type_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("corp_type_name")]
                        public string CorpTypeName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证件类型列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("credentials_type_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("credentials_type_list")]
                        public Types.CredentialsTypeInfo[]? CredentialsTypeList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置主体类型列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_type_list")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_type_list")]
                public Types.CorpTypeInfo[] CorpTypeList { get; set; } = default!;
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
