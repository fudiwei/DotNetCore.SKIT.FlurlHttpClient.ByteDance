namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/supplier/query_callback 接口的响应。</para>
    /// </summary>
    public class POISupplierQueryCallbackResponse : DouyinOpenResponse<POISupplierQueryCallbackResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public string TaskId { get; set; } = default!;

                /// <summary>
                /// 获取或设置任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_status")]
                [System.Text.Json.Serialization.JsonPropertyName("task_status")]
                public int TaskStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置结果链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result_uri")]
                [System.Text.Json.Serialization.JsonPropertyName("result_uri")]
                public string? ResultUrl { get; set; }
            }
        }
    }
}
