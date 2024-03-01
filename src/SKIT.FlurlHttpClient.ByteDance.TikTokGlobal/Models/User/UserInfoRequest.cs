using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [GET] /user/info/ 接口的请求。</para>
    /// </summary>
    public class UserInfoRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

        public UserInfoRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("open_id");
            FieldList.Add("union_id");
            FieldList.Add("avatar_url");
            FieldList.Add("avatar_url_100");
            FieldList.Add("avatar_large_url");
            FieldList.Add("display_name");
            FieldList.Add("bio_description");
            FieldList.Add("profile_deep_link");
            FieldList.Add("is_verified");
            FieldList.Add("follower_count");
            FieldList.Add("following_count");
            FieldList.Add("likes_count");
            FieldList.Add("video_count");
            return this;
        }
    }
}
