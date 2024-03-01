namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /user/data/check/ 接口的响应。</para>
    /// </summary>
    public class UserDataCheckResponse : TikTokV2Response<UserDataCheckResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置申请 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_id")]
                [System.Text.Json.Serialization.JsonPropertyName("request_id")]
                public long RequestId { get; set; }

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_time")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置采集时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("collect_time")]
                [System.Text.Json.Serialization.JsonPropertyName("collect_time")]
                public long CollectTimestamp { get; set; }

                /// <summary>
                /// 获取或设置数据格式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_format")]
                [System.Text.Json.Serialization.JsonPropertyName("data_format")]
                public string DataFormat { get; set; } = default!;

                /// <summary>
                /// 获取或设置数据分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_selection_list")]
                [System.Text.Json.Serialization.JsonPropertyName("category_selection_list")]
                public string[] CategorySelectionList { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;
            }
        }
    }
}
