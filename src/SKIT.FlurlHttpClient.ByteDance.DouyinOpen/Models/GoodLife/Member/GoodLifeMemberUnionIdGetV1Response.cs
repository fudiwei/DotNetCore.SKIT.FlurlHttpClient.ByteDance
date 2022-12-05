namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/member/unionid/get 接口的响应。</para>
    /// </summary>
    public class GoodLifeMemberUnionIdGetV1Response : DouyinOpenResponse<GoodLifeMemberUnionIdGetV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
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
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置会员 UnionId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("union_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("union_id")]
                        public string UnionId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置会员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("members")]
                [System.Text.Json.Serialization.JsonPropertyName("members")]
                public Types.Member[] MemberList { get; set; } = default!;
            }
        }
    }
}
