namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /im/group/enter/audit/get/ 接口的响应。</para>
    /// </summary>
    public class IMGroupEnterAuditGetResponse : DouyinOpenResponse<IMGroupEnterAuditGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }

            public class ApplyItem
            {
                /// <summary>
                /// 获取或设置群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                public string GroupId { get; set; } = default!;

                /// <summary>
                /// 获取或设置入群申请 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_id")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
                public string ApplyId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_status")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_status")]
                public int ApplyStatus { get; set; }

                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_id")]
                [System.Text.Json.Serialization.JsonPropertyName("user_id")]
                public string UserOpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }

            public class ApplyList
            {
                /// <summary>
                /// 获取或设置授权用户列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.ApplyItem[] Items { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public long? NextCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置申请列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_list")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_list")]
        public Types.ApplyList ApplyList { get; set; } = default!;
    }
}
