namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [GET] /user/info/ 接口的响应。</para>
    /// </summary>
    public class UserInfoV2Response : TikTokResponseV2<UserInfoV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class User : UserInfoResponse.Types.Data.Types.User
                    {
                    }
                }

                /// <summary>
                /// 获取或设置用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user")]
                [System.Text.Json.Serialization.JsonPropertyName("user")]
                public Types.User User { get; set; } = default!;
            }
        }
    }
}
