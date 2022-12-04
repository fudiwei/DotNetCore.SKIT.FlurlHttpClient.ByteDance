namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/supplier/match 接口的响应。</para>
    /// </summary>
    public class POISupplierMatchV2Response : DouyinOpenResponse<POISupplierMatchV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                /// <summary>
                /// 获取或设置上传状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_success")]
                [System.Text.Json.Serialization.JsonPropertyName("is_success")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public string? TaskId { get; set; }
            }
        }
    }
}
