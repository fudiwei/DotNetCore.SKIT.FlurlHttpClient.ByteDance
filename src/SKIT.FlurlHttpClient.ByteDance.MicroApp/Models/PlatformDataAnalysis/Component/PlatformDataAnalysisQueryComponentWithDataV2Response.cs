namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_component_with_data/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryComponentWithDataV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ComponentData : PlatformDataAnalysisQueryComponentWithDetailV2Response.Types.Data.Types.VideoData.Types.VideoData.Types.Statistics
                    {
                    }
                }

                /// <summary>
                /// 获取或设置留资组件数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("DataList")]
                [System.Text.Json.Serialization.JsonPropertyName("DataList")]
                public Types.ComponentData[] ComponentDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Total")]
                [System.Text.Json.Serialization.JsonPropertyName("Total")]
                public int TotalCount { get; set; }
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
