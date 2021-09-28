using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /member/batchUpdate 接口的请求。</para>
    /// </summary>
    public class MemberBatchUpdateRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Member
            {
                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string? MobileNumber { get; set; }

                /// <summary>
                /// 获取或设置等级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public int? Level { get; set; }

                /// <summary>
                /// 获取或设置是否解绑。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unbind")]
                [System.Text.Json.Serialization.JsonPropertyName("unbind")]
                public bool? IsUnbind { get; set; }

                /// <summary>
                /// 获取或设置积分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("integral")]
                [System.Text.Json.Serialization.JsonPropertyName("integral")]
                public int? Points { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置新的用户数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("member_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("member_info_list")]
        public IList<Types.Member> MemberList { get; set; } = new List<Types.Member>();
    }
}
