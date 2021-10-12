namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/supplier/query_all 接口的响应。</para>
    /// </summary>
    public class POISupplierQueryAllResponse : TikTokResponse<POISupplierQueryAllResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public string TaskId { get; set; } = default!;
            }
        }
    }
}
