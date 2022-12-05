namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/applyActivities 接口的响应。</para>
    /// </summary>
    public class BuyinApplyActivitiesResponse : DouyinShopResponse<BuyinApplyActivitiesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : BuyinSimplePlanResponse.Types.Data
            {
            }
        }
    }
}
