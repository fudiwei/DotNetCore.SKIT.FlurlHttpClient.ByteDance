namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/poi/poi/sync 接口的响应。</para>
    /// </summary>
    public class GoodLifePOISyncV1Response : DouyinOpenResponse<GoodLifePOISyncV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Task
                    {
                        /// <summary>
                        /// 获取或设置任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long TaskId { get; set; }

                        /// <summary>
                        /// 获取或设置三方 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_id")]
                        public string ThirdId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商家 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                        public string? AccountId { get; set; }

                        /// <summary>
                        /// 获取或设置门店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string POIId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置任务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tasks")]
                [System.Text.Json.Serialization.JsonPropertyName("tasks")]
                public Types.Task[] TaskList { get; set; } = default!;
            }
        }
    }
}
