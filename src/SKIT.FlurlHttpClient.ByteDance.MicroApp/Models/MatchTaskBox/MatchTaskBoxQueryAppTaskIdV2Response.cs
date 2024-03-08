namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /match/v2/taskbox/query_app_task_id/ 接口的响应。</para>
    /// </summary>
    public class MatchTaskBoxQueryAppTaskIdV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置任务 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("task_ids")]
                public long[] TaskIdList { get; set; } = default!;
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
