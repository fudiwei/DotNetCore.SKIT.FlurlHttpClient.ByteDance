namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/platform/v2/data_analysis/query_scene_data/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQuerySceneDataV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SceneData
                    {
                        public static class Types
                        {
                            public class SceneAverageStayTimeData
                            {
                                /// <summary>
                                /// 获取或设置时间格式类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_type")]
                                public int TimeType { get; set; }

                                /// <summary>
                                /// 获取或设置时间字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time")]
                                [System.Text.Json.Serialization.JsonPropertyName("time")]
                                public string TimeString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置次均停留时长（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scene_avg_stay_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("scene_avg_stay_time")]
                                public decimal AverageStayTime { get; set; }
                            }

                            public class SceneUVData
                            {
                                /// <summary>
                                /// 获取或设置时间格式类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_type")]
                                public int TimeType { get; set; }

                                /// <summary>
                                /// 获取或设置时间字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time")]
                                [System.Text.Json.Serialization.JsonPropertyName("time")]
                                public string TimeString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置活跃用户数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scene_uv")]
                                [System.Text.Json.Serialization.JsonPropertyName("scene_uv")]
                                public int UV { get; set; }
                            }

                            public class SceneNewUVData
                            {
                                /// <summary>
                                /// 获取或设置时间格式类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_type")]
                                public int TimeType { get; set; }

                                /// <summary>
                                /// 获取或设置时间字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time")]
                                [System.Text.Json.Serialization.JsonPropertyName("time")]
                                public string TimeString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置新增用户数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scene_new_uv")]
                                [System.Text.Json.Serialization.JsonPropertyName("scene_new_uv")]
                                public int NewUV { get; set; }
                            }

                            public class SceneOpenPVData
                            {
                                /// <summary>
                                /// 获取或设置时间格式类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_type")]
                                public int TimeType { get; set; }

                                /// <summary>
                                /// 获取或设置时间字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time")]
                                [System.Text.Json.Serialization.JsonPropertyName("time")]
                                public string TimeString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置打开次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scene_open_pv")]
                                [System.Text.Json.Serialization.JsonPropertyName("scene_open_pv")]
                                public int OpenPV { get; set; }
                            }

                            public class ScenePVData
                            {
                                /// <summary>
                                /// 获取或设置时间格式类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("time_type")]
                                public int TimeType { get; set; }

                                /// <summary>
                                /// 获取或设置时间字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("time")]
                                [System.Text.Json.Serialization.JsonPropertyName("time")]
                                public string TimeString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置访问次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scene_pv")]
                                [System.Text.Json.Serialization.JsonPropertyName("scene_pv")]
                                public int PV { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置场景值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_id")]
                        public string SceneId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置场景名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_name")]
                        public string SceneName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置次均停留时长（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_avg_stay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_avg_stay_time")]
                        public decimal AverageStayTime { get; set; }

                        /// <summary>
                        /// 获取或设置次均停留时长数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_avg_stay_time_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_avg_stay_time_list")]
                        public Types.SceneAverageStayTimeData[] AverageStayTimeDataList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活跃用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_uv")]
                        public int UV { get; set; }

                        /// <summary>
                        /// 获取或设置活跃用户数数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_uv_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_uv_list")]
                        public Types.SceneUVData[] UVDataList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置新增用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_new_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_new_uv")]
                        public int NewUV { get; set; }

                        /// <summary>
                        /// 获取或设置新增用户数数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_new_uv_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_new_uv_list")]
                        public Types.SceneNewUVData[] NewUVDataList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置打开次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_open_pv")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_open_pv")]
                        public int OpenPV { get; set; }

                        /// <summary>
                        /// 获取或设置打开次数数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_open_pv_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_open_pv_list")]
                        public Types.SceneOpenPVData[] OpenPVDataList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置访问次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_pv")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_pv")]
                        public int PV { get; set; }

                        /// <summary>
                        /// 获取或设置访问次数数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_pv_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_pv_list")]
                        public Types.ScenePVData[] PVDataList { get; set; } = default!;

                    }
                }

                /// <summary>
                /// 获取或设置来源数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_list")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_list")]
                public Types.SceneData[] SceneDataList { get; set; } = default!;
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
