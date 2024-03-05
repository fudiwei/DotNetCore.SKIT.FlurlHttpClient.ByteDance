using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/tags/image 接口的请求。</para>
    /// </summary>
    public class TagsImageV2Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class Task
            {
                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public string ImageUrl { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置置信度服务或目标列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("targets")]
        [System.Text.Json.Serialization.JsonPropertyName("targets")]
        public IList<string> Targets { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置检测任务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tasks")]
        [System.Text.Json.Serialization.JsonPropertyName("tasks")]
        public IList<Types.Task> TaskList { get; set; } = new List<Types.Task>();
    }
}
