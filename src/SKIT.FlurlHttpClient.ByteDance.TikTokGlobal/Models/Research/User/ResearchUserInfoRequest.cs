using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/user/info/ 接口的请求。</para>
    /// </summary>
    public class ResearchUserInfoRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置用户名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;

        public ResearchUserInfoRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("display_name");
            FieldList.Add("bio_description");
            FieldList.Add("avatar_url");
            FieldList.Add("is_verified");
            FieldList.Add("follower_count");
            FieldList.Add("following_count");
            FieldList.Add("likes_count");
            FieldList.Add("video_count");
            return this;
        }
    }
}
