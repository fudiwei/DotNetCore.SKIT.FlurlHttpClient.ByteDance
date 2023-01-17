namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_client_data 接口的响应。</para>
    /// </summary>
    public class AppsDataAnalysisQueryClientDataV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ClientData
                    {
                        /// <summary>
                        /// 获取或设置项目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public int UserCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置客户端版本分布数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_version")]
                [System.Text.Json.Serialization.JsonPropertyName("app_version")]
                public Types.ClientData[] AppVersionDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置基础库版本分布数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lib_version")]
                [System.Text.Json.Serialization.JsonPropertyName("lib_version")]
                public Types.ClientData[] LibraryVersionDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置终端品牌分布数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand")]
                [System.Text.Json.Serialization.JsonPropertyName("brand")]
                public Types.ClientData[] BrandDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置终端机型分布数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("model")]
                [System.Text.Json.Serialization.JsonPropertyName("model")]
                public Types.ClientData[] ModelDataList { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
