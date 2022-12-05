namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/exclusivePlan 接口的响应。</para>
    /// </summary>
    public class BuyinExclusivePlanResponse : DouyinShopResponse<BuyinExclusivePlanResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : BuyinSimplePlanResponse.Types.Data
            {
            }
        }
    }
}
