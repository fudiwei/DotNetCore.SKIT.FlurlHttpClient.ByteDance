namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/subscription/get_subscription_info/ 接口的响应。</para>
    /// </summary>
    public class MinisSubscriptionGetSubscriptionInfoResponse : TikTokV2Response<MinisSubscriptionGetSubscriptionInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Subscription : MinisSubscriptionGetActiveListResponse.Types.Data.Types.Subscription
                    {
                    }
                }

                /// <summary>
                /// 获取或设置订阅信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscription")]
                [System.Text.Json.Serialization.JsonPropertyName("subscription")]
                public Types.Subscription? Subscription { get; set; }
            }
        }
    }
}
