using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/taskbox/update_orient_talents/ 接口的请求。</para>
    /// </summary>
    public class AppsTaskBoxUpdateOrientTalentsRequest : AppsTaskBoxRequestBase
    {
        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("third_appid")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 获取或设置达人抖音号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("douyin_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("douyin_ids")]
        public IList<string> DouyinIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op_type")]
        [System.Text.Json.Serialization.JsonPropertyName("op_type")]
        public int OperateType { get; set; }
    }
}
