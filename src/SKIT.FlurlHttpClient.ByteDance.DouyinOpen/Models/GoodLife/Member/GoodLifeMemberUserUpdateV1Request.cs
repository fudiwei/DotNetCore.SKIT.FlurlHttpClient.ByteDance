using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/member/user/update 接口的请求。</para>
    /// </summary>
    public class GoodLifeMemberUserUpdateV1Request : DouyinOpenRequest
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

                /// <summary>
                /// 获取或设置会员最新积分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("point_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("point_amount")]
                public int PointAmount { get; set; }

                /// <summary>
                /// 获取或设置会员最新等级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_level")]
                [System.Text.Json.Serialization.JsonPropertyName("user_level")]
                public int UserLevel { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家团购账号 ID。
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
