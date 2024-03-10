using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/role/check/ 接口的请求。</para>
    /// </summary>
    public class DouyinRoleCheckV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置身份标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_labels")]
        [System.Text.Json.Serialization.JsonPropertyName("role_labels")]
        public IList<string> RoleLabelList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置用户的 OpenId。与字段 <see cref="DouyinId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置用户抖音号。与字段 <see cref="OpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("douyin_shortId")]
        [System.Text.Json.Serialization.JsonPropertyName("douyin_shortId")]
        public string? DouyinId { get; set; }
    }
}
