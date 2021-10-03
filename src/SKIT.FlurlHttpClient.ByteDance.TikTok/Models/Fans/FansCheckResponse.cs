namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /fans/check 接口的响应。</para>
    /// </summary>
    public class FansCheckResponse : TikTokResponse<FansCheckResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置是否关注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_follower")]
                [System.Text.Json.Serialization.JsonPropertyName("is_follower")]
                public bool IsFollower { get; set; }

                /// <summary>
                /// 获取或设置关注时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("follow_time")]
                [System.Text.Json.Serialization.JsonPropertyName("follow_time")]
                public long? FollowTimestamp { get; set; }
            }
        }
    }
}
