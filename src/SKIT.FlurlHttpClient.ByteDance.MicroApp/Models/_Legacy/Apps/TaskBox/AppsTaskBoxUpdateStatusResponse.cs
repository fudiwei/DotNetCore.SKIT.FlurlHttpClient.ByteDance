using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/taskbox/update/status 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-08 下线。")]
    public class AppsTaskBoxUpdateStatusResponse : AppsTaskBoxResponseBase
    {
        public static class Types
        {
            public class Data : AppsTaskBoxAddTaskResponse.Types.Data
            {
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
