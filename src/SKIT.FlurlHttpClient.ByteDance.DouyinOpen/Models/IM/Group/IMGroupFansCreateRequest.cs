namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/group/fans/create/ 接口的请求。</para>
    /// </summary>
    public class IMGroupFansCreateRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_name")]
        [System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string GroupName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群简介。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avatar_uri")]
        [System.Text.Json.Serialization.JsonPropertyName("avatar_uri")]
        public string AvatarUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置群类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_type")]
        [System.Text.Json.Serialization.JsonPropertyName("group_type")]
        public int? GroupType { get; set; }

        /// <summary>
        /// 获取或设置粉丝活跃度要求。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_fans")]
        [System.Text.Json.Serialization.JsonPropertyName("active_fans")]
        public int? ActiveFansType { get; set; }

        /// <summary>
        /// 获取或设置粉丝团等级要求。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fans_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("fans_limit")]
        public int? FansLimitType { get; set; }

        /// <summary>
        /// 获取或设置关注条件要求。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relation_type")]
        [System.Text.Json.Serialization.JsonPropertyName("relation_type")]
        public int? RelationType { get; set; }

        /// <summary>
        /// 获取或设置是否允许群成员邀请朋友。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_invite")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("allow_invite")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsAllowInvite { get; set; }

        /// <summary>
        /// 获取或设置是否作品自动同步。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_auto_sync")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("item_auto_sync")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsItemAutoSync { get; set; }

        /// <summary>
        /// 获取或设置是否直播自动同步。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("live_auto_sync")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("live_auto_sync")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsLiveAutoSyncType { get; set; }

        /// <summary>
        /// 获取或设置是否开启进群审批。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_audit_switch")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("open_audit_switch")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsOpenAudit { get; set; }

        /// <summary>
        /// 获取或设置是否展示到个人主页。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("show_at_profile")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("show_at_profile")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsShowAtProfile { get; set; }
    }
}
