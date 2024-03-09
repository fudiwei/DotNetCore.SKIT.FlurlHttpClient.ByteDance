using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_capcut_info 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-01 下线。")]
    public class AppsCapacityQueryCapcutInfoV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置剪映号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("capcut_id")]
                [System.Text.Json.Serialization.JsonPropertyName("capcut_id")]
                public string CapcutId { get; set; } = default!;

                /// <summary>
                /// 获取或设置剪映名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("capcut_name")]
                [System.Text.Json.Serialization.JsonPropertyName("capcut_name")]
                public string CapcutName { get; set; } = default!;

                /// <summary>
                /// 获取或设置剪映头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("capcut_avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("capcut_avatar")]
                public string CapcutAvatarUrl { get; set; } = default!;
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
