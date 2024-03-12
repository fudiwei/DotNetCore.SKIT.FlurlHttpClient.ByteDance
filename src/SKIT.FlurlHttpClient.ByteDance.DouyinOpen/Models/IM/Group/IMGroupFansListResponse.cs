namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /im/group/fans/list/ 接口的响应。</para>
    /// </summary>
    public class IMGroupFansListResponse : DouyinOpenResponse<IMGroupFansListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }

            public class Group
            {
                /// <summary>
                /// 获取或设置群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                public string GroupId { get; set; } = default!;

                /// <summary>
                /// 获取或设置群名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_name")]
                [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                public string GroupName { get; set; } = default!;

                /// <summary>
                /// 获取或设置群简介。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar_uri")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar_uri")]
                public string AvatarUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置群类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_type")]
                [System.Text.Json.Serialization.JsonPropertyName("group_type")]
                public int? GroupType { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置群门槛列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entry_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("entry_limit")]
                public string[]? EntryLimitList { get; set; }

                /// <summary>
                /// 获取或设置群现有人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exist_num")]
                [System.Text.Json.Serialization.JsonPropertyName("exist_num")]
                public int? ExistNumber { get; set; }

                /// <summary>
                /// 获取或设置群最大支持进入人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_num")]
                [System.Text.Json.Serialization.JsonPropertyName("max_num")]
                public int? MaxNumber { get; set; }

                /// <summary>
                /// 获取或设置群标签槛列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tags")]
                [System.Text.Json.Serialization.JsonPropertyName("tags")]
                public string[]? TagList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置群列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_list")]
        [System.Text.Json.Serialization.JsonPropertyName("group_list")]
        public Types.Group[] GroupList { get; set; } = default!;
    }
}
