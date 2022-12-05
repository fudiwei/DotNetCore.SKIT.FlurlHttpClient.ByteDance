using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/member/unionid/get 接口的请求。</para>
    /// </summary>
    public class GoodLifeMemberUnionIdGetV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class Member
            {
                /// <summary>
                /// 获取或设置会员 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("members")]
        [System.Text.Json.Serialization.JsonPropertyName("members")]
        public IList<Types.Member> MemberList { get; set; } = new List<Types.Member>();
    }
}
