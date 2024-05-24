using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/douyin/query_user_interact_task/ 接口的响应。</para>
    /// </summary>
    public class AppsDouyinQueryUserInteractTaskV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class TaskInfo
                    {
                        public static class Types
                        {
                            public class Video
                            {
                                public static class Types
                                {
                                    public class InteractInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置是否已完成。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("completed")]
                                        [System.Text.Json.Serialization.JsonPropertyName("completed")]
                                        public bool IsCompleted { get; set; }

                                        /// <summary>
                                        /// 获取或设置阶段值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("stage")]
                                        [System.Text.Json.Serialization.JsonPropertyName("stage")]
                                        public int? Stage { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置视频 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("video_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                                public string VideoId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置视频状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("video_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("video_status")]
                                public int VideoStatus { get; set; }

                                /// <summary>
                                /// 获取或设置是否已完成。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("completed")]
                                [System.Text.Json.Serialization.JsonPropertyName("completed")]
                                public bool IsCompleted { get; set; }

                                /// <summary>
                                /// 获取或设置互动数据字典。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("interact_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("interact_info")]
                                public IDictionary<string, Types.InteractInfo> InteractInfoMap { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        public string TaskId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否有效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_valid")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_valid")]
                        public bool IsValid { get; set; }

                        /// <summary>
                        /// 获取或设置最多参与次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("max_count")]
                        public int MaxCount { get; set; }

                        /// <summary>
                        /// 获取或设置成功次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("success_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("success_count")]
                        public int SuccessCount { get; set; }

                        /// <summary>
                        /// 获取或设置视频列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_info")]
                        public Types.Video[] VideoList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
                        public int ErrorNumber { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
                        public string? ErrorMessage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置任务信息字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("task_info_list")]
                public IDictionary<string, Types.TaskInfo> TaskInfoMap { get; set; } = default!;
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
