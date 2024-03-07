using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/tags/text/antidirt 接口的请求。</para>
    /// </summary>
    public class TagsTextAntiDirtV2Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class Task
            {
                /// <summary>
                /// 获取或设置文本内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置检测任务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tasks")]
        [System.Text.Json.Serialization.JsonPropertyName("tasks")]
        public IList<Types.Task> TaskList { get; set; } = new List<Types.Task>();
    }
}
