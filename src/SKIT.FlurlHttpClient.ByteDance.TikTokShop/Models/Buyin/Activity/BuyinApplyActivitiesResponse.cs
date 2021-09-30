namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/applyActivities 接口的响应。</para>
    /// </summary>
    public class BuyinApplyActivitiesResponse : TikTokShopResponse<BuyinApplyActivitiesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : BuyinSimplePlanResponse.Types.Data
            {
            }
        }
    }
}
