namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/subscription/reactivate/ 接口的响应。</para>
    /// </summary>
    public class MinisSubscriptionReactivateResponse : TikTokV2Response<MinisSubscriptionReactivateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : MinisSubscriptionCreateResponse.Types.Data
            {
            }
        }
    }
}
